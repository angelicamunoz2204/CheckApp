using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class TemplatesxPrintersSplit
    {
        public int SplitId { get; set; }
        public string LayoutId { get; set; }
        public string LayoutPrinterLocation { get; set; }
        public short? PrinterId { get; set; }
        public string AssignedPrinter { get; set; }
        public string ServerName { get; set; }
        public string PrinterShareName { get; set; }
        public string PrinterDescription { get; set; }
    }
}
