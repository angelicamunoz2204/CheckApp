using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class Audit
    {
        public long? BatchId { get; set; }
        public long AtransactNo { get; set; }
        public long? Adate { get; set; }
        public long? Atime { get; set; }
        public string AuserId { get; set; }
        public short? AobjectId { get; set; }
        public string ArecordId { get; set; }
        public string AeditType { get; set; }
        public string FieldChangeString { get; set; }
        public DateTime AuditDateTime { get; set; }
    }
}
