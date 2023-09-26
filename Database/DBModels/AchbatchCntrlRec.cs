using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class AchbatchCntrlRec
    {
        public string RecordTypeCode { get; set; }
        public short? ServiceClassCode { get; set; }
        public int? EntryAddendaCount { get; set; }
        public decimal? EntryHash { get; set; }
        public decimal? TotDebitAmt { get; set; }
        public decimal? TotCreditAmt { get; set; }
        public string CompanyId { get; set; }
        public string MessageAuthCd { get; set; }
        public string Reserved { get; set; }
        public string OriginatingDfiId { get; set; }
        public int? BatchNumber { get; set; }
        public string TransactionType { get; set; }
    }
}
