using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocadExtension
{
    internal class SplineDTO
    {
        public string LineType { get; set; }
        public string LayerName { get; set; }
        public int? ColorNumber { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public override string ToString()
        {
            return $"Line Info:\nLineType - {LineType}, LayerName - {LayerName}, " +
                $"ColorNumber - {ColorNumber},\nStartPoint - {StartPoint}, EndPoint - {EndPoint}" +
                $"\n{new string('=', 10)}";
        }
    }
}
