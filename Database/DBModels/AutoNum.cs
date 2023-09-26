using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class AutoNum
    {
        public short AutonumId { get; set; }
        public long? NextNumber { get; set; }
        public string AutoDescription { get; set; }
    }
}
