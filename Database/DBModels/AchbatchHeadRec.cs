using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class AchbatchHeadRec
    {
        public string RecordTypeCode { get; set; }
        public short? ServiceClassCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDiscretionary { get; set; }
        public string CompanyIdentificatio { get; set; }
        public string StandardEntryClassCo { get; set; }
        public string CompanyEntryDescript { get; set; }
        public string CompanyDescriptiveDa { get; set; }
        public string EffectiveEntryDate { get; set; }
        public short? SettlementDateJulia { get; set; }
        public string OriginatorStatusCode { get; set; }
        public string OriginatingDfiIdent { get; set; }
        public int BatchNumber { get; set; }
    }
}
