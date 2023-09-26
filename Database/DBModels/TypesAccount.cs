using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class TypesAccount
    {
        public string TypeofAccount { get; set; }
        public string Description { get; set; }
        public decimal? MaxValueDefault { get; set; }
        public string AccountId { get; set; }
        public short ProjectKey { get; set; }
        public string FillerTa { get; set; }
    }
}
