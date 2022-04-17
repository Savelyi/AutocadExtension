using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WinForm = System.Windows.Forms;
using Autodesk.AutoCAD.Geometry;

namespace AutocadExtension
{
    public class MyCommandClass
    {
        private static Document testDoc;
        readonly Lab form;
        public MyCommandClass()
        {
            
            form = new Lab();
        }
        /// <summary>
        /// Gives you an opportunity to save info about primitives
        /// </summary>
        [CommandMethod("GetProjectInfo")]
        [STAThread]
        public void RunCommand()
        {
            form.Show();
            //WinForm.DialogResult dialogResult = Application.ShowModalDialog(form);
        }

        //[CommandMethod("GetInfo")]
        public static void GetInfo()
        {
            testDoc = Application.DocumentManager.MdiActiveDocument;
            if (testDoc == null)
                return;
            Database db = testDoc.Database;
            //List<PolylineDTO> polylines = new List<PolylineDTO>();
            //List<Spline> splines = new List<Spline>();
            List<LineDTO> lines = new List<LineDTO>();
            List<PointDTO> points = new List<PointDTO>();
            Dictionary<ObjectId, string> projectEntities = GetAllEntities(db);
            int polylinesCounter = 0;
            int splinesCounter = 0;
            int pointsCouner = 0;


            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                foreach (var item in projectEntities)
                {
                    if (item.Value == "AcDbPoint")
                    {
                        pointsCouner++;
                        DBPoint point = db.TransactionManager.GetObject(item.Key, OpenMode.ForRead) as DBPoint;
                        Point3d point3D = point.Position;
                        points.Add(new PointDTO
                        {
                            Position = $"{point3D.X},{point3D.Y},{point3D.Z}",
                            LayerName = point.Layer
                        });
                    }
                    if (item.Value == "AcDbPolyline")
                    {
                        polylinesCounter++;
                        var line = db.TransactionManager.GetObject(item.Key, OpenMode.ForRead) as Polyline;
                        lines.Add(new LineDTO
                        {
                            LineType = item.Value,
                            StartPoint = $"{line.StartPoint.X},{line.StartPoint.Y},{line.StartPoint.Z}",
                            EndPoint = $"{line.EndPoint.X},{line.EndPoint.Y},{line.EndPoint.Z}",
                            ColorNumber = line.EntityColor.ColorIndex,
                            LayerName = line.Layer
                        });
                    }
                    else if (item.Value == "AcDbSpline")
                    {
                        splinesCounter++;
                        var line = db.TransactionManager.GetObject(item.Key, OpenMode.ForRead) as Spline;
                        lines.Add(new LineDTO
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

            //Editor editor = testDoc.Editor;
            //foreach (var item in lines)
            //{
            //    editor.WriteMessage($"LineInfo:\nLineType - {item.LineType},\nLayerName - {item.LayerName},\n" +
            //        $"ColorNumber - {item.ColorNumber},\n" +
            //        $"StartPoint - {item.StartPoint},\nEndPoint - {item.EndPoint}\n========\n");
            //}
            //foreach (var item in points)
            //{
            //    editor.WriteMessage($"$PointInfo:\nLayerName - {item.LayerName},\nPosition - {item.Position}");
            //}
            //editor.WriteMessage($"|||SplinesFound - {splinesCounter}|||\n" +
            //    $"|||PolylinesFound - {polylinesCounter}");

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
