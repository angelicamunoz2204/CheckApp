using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class Fontlist
    {
        public short ProjectKey { get; set; }
        public string FontSymbolName { get; set; }
        public int FontId { get; set; }
        public bool? SelectedQ { get; set; }
        public string ActivationChar { get; set; }
        public string Description { get; set; }
        public string AdditionalActivation { get; set; }
        public string SystemOrUser { get; set; }
        public string Fspec1 { get; set; }
        public string Fspec2 { get; set; }
        public bool? PdfQ { get; set; }
        public string Filler1 { get; set; }
    }
}
