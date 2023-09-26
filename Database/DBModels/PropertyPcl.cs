using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class PropertyPcl
    {
        public string PropertyId { get; set; }
        public string PrefixCommand { get; set; }
        public string SuffixCommand { get; set; }
        public short? PtyDefaultSequence { get; set; }
    }
}
