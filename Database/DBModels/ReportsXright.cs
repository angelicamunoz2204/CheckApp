using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class ReportsXright
    {
        public string RightId { get; set; }
        public string ExProg2Call { get; set; }
        public bool? ExternalRepQ { get; set; }
        public string Description { get; set; }
        public string Filler { get; set; }
    }
}
