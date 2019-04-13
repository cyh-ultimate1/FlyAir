using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.FlightModels
{
    public class FlightDestCount
    {
        public int FreqCount { get; set; }

        public int DestLocID { get; set; }

        public string DestCityName { get; set; }

        public string DestCountryName { get; set; }
    }
}
