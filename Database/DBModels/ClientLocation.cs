using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class ClientLocation
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Selected { get; set; }
        public bool? Csreplicated { get; set; }
        public int? CsTimeOut { get; set; }
        public int? CsRefreshTime { get; set; }
        public string PrinterName { get; set; }
        public string Template { get; set; }
        public int? PrinterId { get; set; }
    }
}
