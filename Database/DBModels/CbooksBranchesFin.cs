using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class CbooksBranchesFin
    {
        public string BankId { get; set; }
        public string BranchId { get; set; }
        public string BranchName { get; set; }
        public int? CheckSeqNumber { get; set; }
        public string CurrencyId { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Addr4 { get; set; }
        public int? FontId { get; set; }
        public string Brtransit1 { get; set; }
        public string Brtransit2 { get; set; }
        public string Brtransit3 { get; set; }
        public string BrtransitMicr { get; set; }
        public string Fillerb { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
    }
}
