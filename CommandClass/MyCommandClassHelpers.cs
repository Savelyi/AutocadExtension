using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;

namespace AutocadExtension
{
    internal static class MyCommandClassHelpers
    {

        private static Document testDoc;

        public static GeneralInfoDTO GetInfo()
        {
            testDoc = Application.DocumentManager.MdiActiveDocument;
            if (testDoc == null)
                return null;
            var ed = testDoc.Editor;
            var ucs = ed.CurrentUserCoordinateSystem;
            Database db = testDoc.Database;
            GeneralInfoDTO infoDTO = new GeneralInfoDTO();
            Dictionary<ObjectId, string> projectEntities = GetAllEntities(db);
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                foreach (var item in projectEntities)
                {
                    if (item.Value == "AcDbPoint")
                    {

                        DBPoint point = db.TransactionManager.GetObject(item.Key, OpenMode.ForRead) as DBPoint;
                        Point3d point3D = point.Position;
                        infoDTO.Points.Add(new PointDTO
                        {
                            Position = $"{point3D.X},{point3D.Y},{point3D.Z}",
                            LayerName = point.Layer
                        });
                        continue;
                    }
                    if (item.Value == "AcDbPolyline")
                    {
                        var pointCollection = new Point3dCollection();
                        var pline = db.TransactionManager.GetObject(item.Key, OpenMode.ForRead) as Polyline;
                        for (int i = 0; i < pline.NumberOfVertices; i++)
                        {
                            pointCollection.Add(pline.GetPoint3dAt(i).TransformBy(ucs));
                        }

                        List<double> Radiuses=new List<double>();
                        if (pline.HasBulges)
                        {
                            double bulge;
                            for (int i = 0; i < pline.NumberOfVertices; i++)
                            {
                                bulge = pline.GetBulgeAt(i);
                                if (bulge != 0)
                                {
                                    var point1=pline.GetPoint3dAt(i).TransformBy(ucs);
                                    var point2=pline.GetPoint3dAt(i+1).TransformBy(ucs);
                                    double d = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2))/2;
                                    double radius = (d * (Math.Pow(bulge, 2) + 1)) / (2 * bulge);
                                    Radiuses.Add(radius);
                                }
                            }
                        }
                        infoDTO.PolyLines.Add(new PolyLineDTO(db)
                        {
                            LineType = item.Value,
                            StartPoint = $"{pline.StartPoint.X},{pline.StartPoint.Y},{pline.StartPoint.Z}",
                            EndPoint = $"{pline.EndPoint.X},{pline.EndPoint.Y},{pline.EndPoint.Z}",
                            ColorNumber = pline.EntityColor.ColorIndex,
                            LayerName = pline.Layer,
                            Points=pointCollection,
                            RadiusCollection=Radiuses
                        });
                        continue;
                    }
                    if (item.Value == "AcDbSpline")
                    {
                        var pointCollection = new Point3dCollection();
                        var line = db.TransactionManager.GetObject(item.Key, OpenMode.ForRead) as Spline;
                        for (int i = 0; i < line.NumControlPoints; i++)
                        {
                            pointCollection.Add(line.GetFitPointAt(i).TransformBy(ucs));
                        }
                        infoDTO.Splines.Add(new SplineDTO(db)
                        {
                            LineType = item.Value,
                            StartPoint = $"{line.StartPoint.X},{line.StartPoint.Y},{line.StartPoint.Z}",
                            EndPoint = $"{line.EndPoint.X},{line.EndPoint.Y},{line.EndPoint.Z}",
                            ColorNumber = line.EntityColor.ColorIndex,
                            LayerName = line.Layer,
                            Points = pointCollection
                        });
                    }
                }
                tr.Commit();
            }
            return infoDTO;
        }
        static Dictionary<ObjectId, string> GetAllEntities(Database db)
        {
            var dict = new Dictionary<ObjectId, string>();
            using (var tr = db.TransactionManager.StartOpenCloseTransaction())
            {
                var bt = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                foreach (var btrId in bt)
                {
                    var btr = (BlockTableRecord)tr.GetObject(btrId, OpenMode.ForRead);
                    if (btr.IsLayout)
                    {
                        foreach (var id in btr)
                        {
                            dict.Add(id, id.ObjectClass.Name);
                        }
                    }
                }
                tr.Commit();
            }
            return dict;
        }
    }
}