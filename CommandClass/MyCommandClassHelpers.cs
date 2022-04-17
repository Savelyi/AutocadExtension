using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
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

                        var line = db.TransactionManager.GetObject(item.Key, OpenMode.ForRead) as Polyline;
                        infoDTO.PolyLines.Add(new PolyLineDTO
                        {
                            LineType = item.Value,
                            StartPoint = $"{line.StartPoint.X},{line.StartPoint.Y},{line.StartPoint.Z}",
                            EndPoint = $"{line.EndPoint.X},{line.EndPoint.Y},{line.EndPoint.Z}",
                            ColorNumber = line.EntityColor.ColorIndex,
                            LayerName = line.Layer
                        });
                        continue;
                    }
                    if (item.Value == "AcDbSpline")
                    {
                        var line = db.TransactionManager.GetObject(item.Key, OpenMode.ForRead) as Spline;
                        infoDTO.Splines.Add(new SplineDTO
                        {
                            LineType = item.Value,
                            StartPoint = $"{line.StartPoint.X},{line.StartPoint.Y},{line.StartPoint.Z}",
                            EndPoint = $"{line.EndPoint.X},{line.EndPoint.Y},{line.EndPoint.Z}",
                            ColorNumber = line.EntityColor.ColorIndex,
                            LayerName = line.Layer
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