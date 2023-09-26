using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class CbooksBankFin
    {
        public string BankId { get; set; }
        public string BankName { get; set; }
        public int? FontId { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Addr4 { get; set; }
        public string BranchOfficeCode { get; set; }
        public string BankCode { get; set; }
        public string TransitFraccion1 { get; set; }
        public string TransitFraccion2 { get; set; }
        public string TransitFraccion3 { get; set; }
        public string TransitMicr { get; set; }
        public string ApplF { get; set; }
        public short? ProjectKey { get; set; }
        public string DefaultCurrency { get; set; }
        public string Filler { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public string Col5 { get; set; }
    }
}
