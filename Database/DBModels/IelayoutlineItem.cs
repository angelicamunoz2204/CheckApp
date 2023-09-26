using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class IelayoutlineItem
    {
        public string GeneralCode { get; set; }
        public string RecordType { get; set; }
        public string FieldCode { get; set; }
        public string IeidDescription { get; set; }
        public string IeidType { get; set; }
        public short? IeidLength { get; set; }
        public short? IeidOffsetpos { get; set; }
        public short Kkey { get; set; }
        public string KparentCode { get; set; }
        public string Constant { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
    }
}
