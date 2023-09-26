using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class BatchSignatory
    {
        public long BatchId { get; set; }
        public int RecordNo { get; set; }
        public int? DateBs { get; set; }
        public int? TimeBs { get; set; }
        public string UserId { get; set; }
        public int? FontId { get; set; }
        public string PrimaryOrSecondary { get; set; }
        public bool? EnableOrDisable { get; set; }
        public string FillerBs { get; set; }

        public virtual BtchDet Batch { get; set; }
    }
}
