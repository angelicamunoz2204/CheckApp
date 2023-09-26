using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class CbooksSynonym
    {
        public string SynonymId { get; set; }
        public string LayoutId { get; set; }
        public string ApplS { get; set; }
        public string TypeOfAccount { get; set; }
        public string CheckLayoutNo { get; set; }
        public short? VertMicrmicroAdjust { get; set; }
        public short? HorizMicrmicroAdjust { get; set; }
        public short? ProjectKey { get; set; }
        public string CurrencyId { get; set; }
        public int? SetLastCheckNumber { get; set; }
        public string FillerS { get; set; }
        public string EndLayout { get; set; }
        public string Layout1 { get; set; }
        public string Layout2 { get; set; }
    }
}
