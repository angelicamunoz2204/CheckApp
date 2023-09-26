using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class TemplatesxPrintersAll
    {
        public int Id { get; set; }
        public string ServerName { get; set; }
        public string PrinterName { get; set; }
        public string ShareName { get; set; }
        public DateTime? UpdDate { get; set; }
        public string WindowsUser { get; set; }
        public string UserId { get; set; }
        public string WindowsPc { get; set; }
    }
}
