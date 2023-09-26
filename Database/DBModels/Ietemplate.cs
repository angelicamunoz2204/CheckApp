using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class Ietemplate
    {
        public string Tapplication2run { get; set; }
        public string TrecordType { get; set; }
        public short Tkey { get; set; }
        public string Tdescription { get; set; }
        public string Ttype { get; set; }
        public short? Tlength { get; set; }
        public bool? TessentialQ { get; set; }
        public bool? TselectedQ { get; set; }
        public string Tclassifier { get; set; }
    }
}
