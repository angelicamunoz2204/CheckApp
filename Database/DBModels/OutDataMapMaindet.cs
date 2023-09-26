using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class OutDataMapMaindet
    {
        public string LayoutId { get; set; }
        public short FomrItemId { get; set; }
        public short Seq2Print { get; set; }
        public string PropertyId { get; set; }
        public float? PropValue { get; set; }
        public short DetSequence { get; set; }
    }
}
