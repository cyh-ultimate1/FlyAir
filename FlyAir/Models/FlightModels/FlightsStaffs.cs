using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.FlightModels
{
    public class FlightsStaffs
    {
        public int FlightID { get; set; }

        public int StaffID { get; set; }

        //table name
        public const string tableName = "FlightsStaffs";
    }
}
