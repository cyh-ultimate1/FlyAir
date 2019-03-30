using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.StaffModels
{
    public class Staff
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Staff Type")]
        public byte StaffTypeID { get; set; }

        public virtual StaffType StaffType { get; set; }

        [Display(Name = "Staff Type Name")]
        public virtual string Type { get; set; }

        //public string Discriminator { get; set; }

        //table name
        public const string tableName = "Staffs";
    }
}
