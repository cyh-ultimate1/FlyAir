using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models
{
    public static class commonName
    {
        public const string defaultConn = "DefaultConnection";
        //public const string admin = "Admin";
        public const string superAdmin = "SuperAdmin";
        public const string addReturnIntQuery = "SELECT CAST(SCOPE_IDENTITY() as int);";
        public const string alphabetStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public const string identityRoleTable = "IdentityRole";
    }
}
