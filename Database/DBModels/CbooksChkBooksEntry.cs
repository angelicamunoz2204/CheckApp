using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class CbooksChkBooksEntry
    {
        public string AccountNo { get; set; }
        public string BankId { get; set; }
        public short? NoChecks2Print { get; set; }
        public string TypeAccount { get; set; }
        public string StatusofCheck { get; set; }
        public string Currency { get; set; }
        public int? CreationDate { get; set; }
        public int? PrintedDate { get; set; }
        public string UserId { get; set; }
        public string RoutingTransitInfo { get; set; }
        public bool? FlagprintNotAllowed { get; set; }
        public string FillerCb { get; set; }
        public string LocationId { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public string Col5 { get; set; }
    }
}
