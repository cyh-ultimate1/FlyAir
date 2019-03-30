using FlyAir.Models.FlightModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.StaffModels
{
    public class StaffVM : Staff
    {
        public virtual List<SelectListItem> StaffTypesList { get; set; }

        public virtual IEnumerable<Flight> Flights { get; set; }

        //var to temporarily store newly added user.
        public virtual int tempUserid { get; set; }
    }
}
