using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class EmailPref
    {
        public bool? DefaultValueE { get; set; }
        public string SmptServer { get; set; }
        public string FromE { get; set; }
        public string SubjectE { get; set; }
        public string MessageE { get; set; }
        public string AttachmentE { get; set; }
        public string CategoryE { get; set; }
        public string BlattOptions { get; set; }
        public short? DigitsDisclose { get; set; }
        public short? PacingTimer { get; set; }
        public string ToE { get; set; }
    }
}
