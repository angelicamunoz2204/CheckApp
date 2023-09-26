using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class CbooksMicrline
    {
        public string BankId { get; set; }
        public string Micrline { get; set; }
        public short? SerialLength { get; set; }
        public short? AcctLength { get; set; }
        public short? TransactLength { get; set; }
        public short? AmtLength { get; set; }
        public short? AccNoEffectiveLength { get; set; }
        public short? Notused { get; set; }
        public string LayoutId { get; set; }
        public bool? ZeroFillacctL { get; set; }
        public bool? ZeroFillcheckNumberL { get; set; }
        public short? Acctoff { get; set; }
        public short? Column0 { get; set; }
        public string AcctNoMask { get; set; }
        public string FillerM { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
    }
}
