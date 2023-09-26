using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class FeesTable
    {
        public string CurrencyId { get; set; }
        public string AmountOrpercent { get; set; }
        public decimal? PercentComm { get; set; }
        public decimal? Fee { get; set; }
        public decimal? FromAmt { get; set; }
        public decimal? ToAmt { get; set; }
        public string FeeCurrency { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
    }
}
