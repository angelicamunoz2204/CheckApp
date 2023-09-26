using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class SignComboH
    {
        public int SeqNo { get; set; }
        public string Description { get; set; }
        public decimal? FromAmount { get; set; }
        public decimal? ToAmount { get; set; }
        public string Reference { get; set; }
        public decimal? SuggestedFromValue { get; set; }
        public decimal? SuggestedToValue { get; set; }
        public string PayorId { get; set; }
        public string FillerCh { get; set; }
    }
}
