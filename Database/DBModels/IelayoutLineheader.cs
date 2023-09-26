using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class IelayoutLineheader
    {
        public string GeneralCode { get; set; }
        public string RecordType { get; set; }
        public string IeidLinecode { get; set; }
        public string IeidDescription { get; set; }
        public string IeidOperation { get; set; }
        public string Filler { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
    }
}
