using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocadExtension
{
    internal class GeneralInfoDTO
    {
        public GeneralInfoDTO()
        {
            Splines = new List<SplineDTO>();
            PolyLines = new List<PolyLineDTO>();
            Points = new List<PointDTO>();

        }
        public List<SplineDTO> Splines { get; set; }
        public List<PolyLineDTO> PolyLines{ get; set; }
        public List<PointDTO> Points { get; set; }
    }
}
