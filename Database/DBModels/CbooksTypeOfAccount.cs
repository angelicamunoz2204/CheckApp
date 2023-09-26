using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class CbooksTypeOfAccount
    {
        public int RecordNo { get; set; }
        public string TypeOfaccount { get; set; }
        public string LayoutId { get; set; }
        public string CheckLayoutNo { get; set; }
        public string ApplF { get; set; }
        public short ProjectKey { get; set; }
        public int SetStartingChkNo { get; set; }
        public short NoChecks2Print { get; set; }
        public string FillerT { get; set; }
        public string PageNumbering { get; set; }
        public decimal? PriceStyle1 { get; set; }
        public decimal? PriceStyle2 { get; set; }
        public decimal? PriceStyle3 { get; set; }
        public string SelectedStyle { get; set; }
        public int? TotalsChecksPerCbook { get; set; }
    }
}
