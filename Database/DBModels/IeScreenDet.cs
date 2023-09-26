using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class IeScreenDet
    {
        public string GenCode { get; set; }
        public string RecType { get; set; }
        public string IeidFieldCode { get; set; }
        public string IeidDescription { get; set; }
        public string Ieidtype { get; set; }
        public short? IeidLengthInFile { get; set; }
        public short? IeidPosition { get; set; }
        public short? IesdKey { get; set; }
        public string IesdMask { get; set; }
        public string IesdFiller { get; set; }
    }
}
