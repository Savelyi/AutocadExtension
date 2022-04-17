using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocadExtension
{
    internal class PointDTO
    {
        public string Position { get; set; }
        public string LayerName { get; set; }

        public override string ToString()
        {
            return $"Point Info:\nPosition - {Position}, LayerName - {LayerName}\n{new string('=',10)}";
        }
    }
}
