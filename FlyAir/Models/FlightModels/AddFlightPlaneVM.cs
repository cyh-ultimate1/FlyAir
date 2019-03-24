using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.FlightModels
{
    public class AddFlightPlaneVM
    {
        public Flight Flight { get; set; }

        public Plane Plane { get; set; }

        public IEnumerable<SelectListItem> FlightSeatTypes { get; set; }
    }
}
