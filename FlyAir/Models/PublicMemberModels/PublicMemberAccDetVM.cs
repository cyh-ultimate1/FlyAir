using FlyAir.Models.BookingModels;
using FlyAir.Models.FlightModels;
using FlyAir.Models.IdentityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.PublicMemberModels
{
    public class PublicMemberAccDetVM
    {
        public CustomUser User { get; set; }

        public Flight LatestFlight { get; set; }
    }
}
