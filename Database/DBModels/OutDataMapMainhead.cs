using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class OutDataMapMainhead
    {
        public string LayoutId { get; set; }
        public short Group1 { get; set; }
        public short? EntityId { get; set; }
        public string Description2Print { get; set; }
        public string Note { get; set; }
        public string Flags { get; set; }
        public string Mask { get; set; }
        public short ProjectKey { get; set; }
        public short Seq2Print { get; set; }
    }
}
