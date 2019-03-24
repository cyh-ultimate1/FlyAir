using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models
{
    public class Location
    {
        public int ID { get; set; }

        public string City { get; set; }

        public int CountryID { get; set; }

        public virtual string CountryName { get; set; }

        public const string tableName = "Location";
    }
}
