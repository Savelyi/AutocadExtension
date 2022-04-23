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
        public List<Point3d> Points { get; set; }
        public List<double> RadiusCollection { get; set; }
        public override string ToString()
        {
            int i = 0;
            string RadiusStr = "";
            if (RadiusCollection.Count > 0)
            {
                RadiusStr = "RadiusCollection:\n";
                foreach (var item in RadiusCollection)
                {
                    RadiusStr += $"{i++}. {item}\n";
                }
            }
            string pointsStr = GetPointsToString();
            return $"Line Info:\nLineType - {LineType}, LayerName - {LayerName}, " +
                $"ColorNumber - {ColorNumber},\nStartPoint - {StartPoint}, EndPoint - {EndPoint}" +
                $"\nIncluded Points:\n" +
                $"{pointsStr}" +
                $"{RadiusStr}" +
                $"\n{new string('=', 10)}";
        }

        private string GetPointsToString()
        {
            string outputStr = "";
            for (int i = 0; i < Points.Count; i++)
            {
                outputStr += $"Point {i}: {Points[i].X}, {Points[i].Y}, {Points[i].Z}\n";
            }
            return outputStr;
        }
    }
}
