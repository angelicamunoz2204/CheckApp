using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class AsaltSignat
    {
        public int? SignatureFontIdalt { get; set; }
        public int? AltSignatoryalt { get; set; }
        public bool? AssignedQalt { get; set; }
        public decimal? ExtendedAmountLimita { get; set; }
        public short? ProjectKey { get; set; }
        public string FillerAs { get; set; }
    }
}
