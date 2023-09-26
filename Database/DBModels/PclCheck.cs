using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class PclCheck
    {
        public string LayoutId { get; set; }
        public short Group1 { get; set; }
        public short? EntityId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string Flags { get; set; }
        public string Mask { get; set; }
        public short Order2Print { get; set; }
        public string LineProperties { get; set; }
    }
}
