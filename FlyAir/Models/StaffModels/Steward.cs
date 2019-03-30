using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.StaffModels
{
    public class Steward
    {
        [Key]
        public int StaffID { get; set; }

        public string StewardLicence { get; set; }

        //table name
        public const string tableName = "Stewards";
    }
}
