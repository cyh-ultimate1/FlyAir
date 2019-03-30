using FlyAir.Models.StaffModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.FlightModels
{
    public class AddFlightStaffsVM
    {
        public Flight Flight { get; set; }

        public IEnumerable<Staff> StaffsOnFlight { get; set; }

        public IEnumerable<SelectListItem> PilotsAvailable { get; set; }

        public IEnumerable<SelectListItem> StewardsAvailable { get; set; }

        public IEnumerable<int> PilotsSelectedId { get; set; }

        public IEnumerable<int> StewardsSelectedId { get; set; }
    }
}
