using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class GenSysUser
    {
        public string NumberOfUsers { get; set; }
        public DateTime? LicenseDateTime { get; set; }
    }
}
