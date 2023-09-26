using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class AuthSignCompany
    {
        public int FontId { get; set; }
        public string PayorId { get; set; }
        public bool? AssignedQ { get; set; }
        public short ProjectKey { get; set; }
        public string Filler1 { get; set; }
    }
}
