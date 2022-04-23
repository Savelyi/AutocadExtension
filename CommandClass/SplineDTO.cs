using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocadExtension
{
    internal class SplineDTO
    {
        readonly Database db;
        public SplineDTO(Database database)
        {
            db = database;
        }
        public string LineType { get; set; }
        public string LayerName { get; set; }
        public int? ColorNumber { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public List<Point3d> Points { get; set; }
        public override string ToString()
        {
            string pointsStr=GetPointsToString();
            return $"Line Info:\nLineType - {LineType}, LayerName - {LayerName}, " +
                $"ColorNumber - {ColorNumber},\nStartPoint - {StartPoint}, EndPoint - {EndPoint}" +
                $"\nIncluded Points:\n" +
                $"{pointsStr}" +
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
