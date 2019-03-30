using FlyAir.Models.FlightModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.ViewModels
{
    public class FlightsInputsVM
    {
        public IEnumerable<Flight> GoFlights { get; set; }

        public IEnumerable<Flight> ReturnFlights { get; set; }

        public int OriginID { get; set; }

        public int DestID { get; set; }

        public string OriginName { get; set; }

        public string DestName { get; set; }

        [JsonProperty(PropertyName = "adjustgoflight")]
        public virtual bool adjustGoFlight { get; set; } = false;
    }
}
