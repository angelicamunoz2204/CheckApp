using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class EAlertCustom
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public bool? Enable { get; set; }
        public decimal AmountOver { get; set; }
        public string Name1 { get; set; }
        public string NameId { get; set; }
        public string Entity1 { get; set; }
        public string Entity2 { get; set; }
        public string Entity3 { get; set; }
        public string Entity4 { get; set; }
        public string Entity5 { get; set; }
        public string Entity1Text { get; set; }
        public string Entity2Text { get; set; }
        public string Entity3Text { get; set; }
        public string Entity4Text { get; set; }
        public string Entity5Text { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public bool? Enable2 { get; set; }
        public bool? Enable3 { get; set; }
        public decimal? Amount1 { get; set; }
        public decimal? Amount2 { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
    }
}
