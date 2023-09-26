using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class ElegiblePrinter
    {
        public string UserId { get; set; }
        public short? TrayNumber { get; set; }
        public string MarginName { get; set; }
        public bool? SecurePrinterQ { get; set; }
        public short? AvailablePrinters { get; set; }
        public bool? LoadBalanceQ { get; set; }
        public bool? OmitInitQ { get; set; }
        public short PrinterId { get; set; }
        public string AssignedPrinter { get; set; }
        public string Orientation { get; set; }
        public string PaperSize { get; set; }
        public bool? SelectedQ { get; set; }
        public string InitString { get; set; }
        public short? ProjectKey { get; set; }
    }
}
