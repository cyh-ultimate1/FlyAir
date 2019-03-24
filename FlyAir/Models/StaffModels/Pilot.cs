using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.StaffModels
{
    public class Pilot
    {
        [Key]
        public int StaffID { get; set; }

        [Required]
        public string PilotLicenceNum { get; set; }

        //table name
        public const string tableName = "Pilots";
    }
}
