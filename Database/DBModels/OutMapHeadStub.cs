using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class OutMapHeadStub
    {
        public string LayoutId { get; set; }
        public short Groups { get; set; }
        public short? EntityIds { get; set; }
        public string StaticValue2Print { get; set; }
        public string Notes { get; set; }
        public string Flags { get; set; }
        public string Masks { get; set; }
        public short ProjectKey { get; set; }
        public short PrintSequences { get; set; }
    }
}
