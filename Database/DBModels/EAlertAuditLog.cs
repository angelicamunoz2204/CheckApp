using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class EAlertAuditLog
    {
        public int Idnumber { get; set; }
        public int DatabaseId { get; set; }
        public string DatabaseName { get; set; }
        public string Events2Alert { get; set; }
        public string EventMenu { get; set; }
    }
}
