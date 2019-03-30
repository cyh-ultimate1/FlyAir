using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.FlightModels
{
    public class AddPlaneVM
    {
        public AddPlaneVM()
        {
            Plane = new Plane();
        }

        public Plane Plane { get; set; }

        public List<SelectListItem> FlightSeatTypes { get; set; }
    }
}
