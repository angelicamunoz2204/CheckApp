using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class AchbatchDetail
    {
        public long BatchId { get; set; }
        public string Description { get; set; }
        public int? ImportDate { get; set; }
        public string OtherInfo { get; set; }
        public bool? AllAchGeneratedQ { get; set; }
        public bool? ServerRefresedQ { get; set; }
        public int? BatchPurgeDate { get; set; }
        public bool? BatchPurgedQ { get; set; }
        public bool? AllChecksPrintedQ { get; set; }
        public int? TotalChecksInBatch { get; set; }
        public string PayorId { get; set; }
        public string Alpha12 { get; set; }
        public int? Date1 { get; set; }
        public bool? Logical1 { get; set; }
        public decimal? Numeric10 { get; set; }
        public int? Date2 { get; set; }
        public int? Time1 { get; set; }
        public bool? Posted2AchbookQ { get; set; }
        public int? Date3 { get; set; }
        public int? Time2 { get; set; }
        public string BatchType { get; set; }
        public string UserBatchId { get; set; }
        public bool? AutorizedQ { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public int? ImportTime { get; set; }
        public decimal? TotalAmountValue { get; set; }
        public decimal? TotalAcknowledged { get; set; }
        public bool? AchwhileProcessingFl { get; set; }
        public string Filler15 { get; set; }
        public DateTime? BatchImportDateTime { get; set; }
        public DateTime? BatchPostedDateTime { get; set; }

        public virtual BtchDet Batch { get; set; }
    }
}
