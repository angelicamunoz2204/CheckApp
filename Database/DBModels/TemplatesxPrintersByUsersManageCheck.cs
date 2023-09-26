using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class TemplatesxPrintersByUsersManageCheck
    {
        public string LayoutId { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public DateTime? DateTimeEdit { get; set; }
    }
}
