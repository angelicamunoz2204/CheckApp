using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class SignatCostCenter
    {
        public string TypeOfAccount { get; set; }
        public int FontId { get; set; }
        public decimal? MaxValue { get; set; }
        public short ProjectKey { get; set; }
        public string Filler { get; set; }
    }
}
