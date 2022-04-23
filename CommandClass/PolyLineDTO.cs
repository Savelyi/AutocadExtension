using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocadExtension
{
    internal class PolyLineDTO
    {
        readonly Database db;
        public PolyLineDTO(Database database)
        {
            db = database;
            RadiusCollection = new List<double>();

        }
        public string LineType { get; set; }
        public string LayerName { get; set; }
        public int? ColorNumber { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public Point3dCollection Points { get; set; }
        public List<double> RadiusCollection { get; set; }
        public override string ToString()
        {
            string RadiusStr = "RadiusCollection:\n";
            for (int i = 0; i < RadiusCollection.Count; i++)
            {
                RadiusStr += $"{i}. {RadiusCollection[i]}\n";
            }
            string pointsStr = GetPointsToString();
            return $"Line Info:\nLineType - {LineType}, LayerName - {LayerName}, " +
                $"ColorNumber - {ColorNumber},\nStartPoint - {StartPoint}, EndPoint - {EndPoint}" +
                $"Included Points:\n" +
                $"{pointsStr}" +
                $"{RadiusStr}" +
                $"\n{new string('=', 10)}";
        }

        private string GetPointsToString()
        {
            string outputStr = "";
            List<Point3d> points = Points.Cast<Point3d>().ToList();
            for (int i = 0; i < points.Count; i++)
            {
                outputStr += $"Point {i}: {points[i].X}, {points[i].Y}, {points[i].Z}\n";
            }
            return outputStr;
        }
    }
}
