using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.StaffModels
{
    public class StaffType
    {
        public byte ID { get; set; }

        public string Type { get; set; }

        //table name
        public const string tableName = "StaffTypes";

    }
}
