using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class Currency
    {
        public string CurrencyId { get; set; }
        public string CurrencySymbol { get; set; }
        public string Description { get; set; }
        public string DescriptionAddl { get; set; }
        public decimal? ExchangeRate { get; set; }
        public short? ProjectKey { get; set; }
        public string FractionName { get; set; }
        public string Filler { get; set; }
    }
}
