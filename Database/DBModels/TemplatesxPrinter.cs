using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class TemplatesxPrinter
    {
        public string LayoutId { get; set; }
        public short? TrayNumber { get; set; }
        public string MarginName { get; set; }
        public bool? PermanentFontsQ { get; set; }
        public short? AvailablePrinters { get; set; }
        public bool? LoadBalanceQ { get; set; }
        public bool? OmitInitializationQ { get; set; }
        public short PrinterId { get; set; }
        public string AssignedPrinter { get; set; }
        public string Orientation { get; set; }
        public string PaperSize { get; set; }
        public bool? SelectedQ { get; set; }
        public string InitString { get; set; }
        public short ProjectKey { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string PrinterSecurityFeatu { get; set; }
        public string Initializ { get; set; }
        public bool? PermFonts { get; set; }
    }
}
