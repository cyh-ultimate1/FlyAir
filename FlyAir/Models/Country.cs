using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models
{
    public class Country
    {
        public int ID { get; set; }

        //UNIQUE
        [Required]
        public string CountryName { get; set; }

        //table name
        public const string tableName = "Countries";
    }
}
