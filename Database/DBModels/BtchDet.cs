using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class BtchDet
    {
        public BtchDet()
        {
            Achqueues = new HashSet<Achqueue>();
            BatchSignatories = new HashSet<BatchSignatory>();
            ChecksD1s = new HashSet<ChecksD1>();
            ChecksH3s = new HashSet<ChecksH3>();
        }

        public long BatchId { get; set; }
        public string Description { get; set; }
        public int? ImportDate { get; set; }
        public string OtherInfo { get; set; }
        public bool? AchGeneratedQ { get; set; }
        public bool? ServerRefresedQ { get; set; }
        public int? BatchPurgeDate { get; set; }
        public bool? BatchPurgedQ { get; set; }
        public bool? AllChecksBatchPrinte { get; set; }
        public int? TotalChecksinBatch { get; set; }
        public string GpbatchId { get; set; }
        public int? Gpdate { get; set; }
        public bool? CopyprintedQ { get; set; }
        public decimal? PostingGroupId { get; set; }
        public int? DatePosted { get; set; }
        public int? TimePosted { get; set; }
        public bool? PostedTobookQ { get; set; }
        public int? DatePostedReptPrinte { get; set; }
        public int? TimePostedReportPrin { get; set; }
        public string TypeofBatch { get; set; }
        public string Userbatchid { get; set; }
        public bool? AutorizedQ { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public int? ImportTime { get; set; }
        public decimal? Totalamountvalue { get; set; }
        public decimal? Totalacknowledged { get; set; }
        public bool? AchwhileprocessingFl { get; set; }
        public string Filler9915 { get; set; }
        public DateTime? BatchImportDateTime { get; set; }
        public DateTime? BatchPostedDateTime { get; set; }

        public virtual AchbatchDetail AchbatchDetail { get; set; }
        public virtual ICollection<Achqueue> Achqueues { get; set; }
        public virtual ICollection<BatchSignatory> BatchSignatories { get; set; }
        public virtual ICollection<ChecksD1> ChecksD1s { get; set; }
        public virtual ICollection<ChecksH3> ChecksH3s { get; set; }
    }
}
