using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class IeScreenHead
    {
        public string IeihPurpose { get; set; }
        public string GenCode { get; set; }
        public string RecType { get; set; }
        public bool? IeihGenCheckNumberQ { get; set; }
        public string IeihGenDescript { get; set; }
        public string Ieihfilter { get; set; }
        public short? IeihEngineVersion { get; set; }
        public bool? IeihOmitBlanksQ { get; set; }
        public short? ProjectKey { get; set; }
        public short? IehPaddingChar4Expor { get; set; }
        public short? IeihDivideAmountsBy { get; set; }
        public bool? IeihSpare { get; set; }
        public string IeihAppl2run { get; set; }
        public string Ieihpath { get; set; }
        public bool? IeihSelectedQ { get; set; }
        public string IeihFieldSeparatorDe { get; set; }
        public string IeihModeVertHoriz { get; set; }
        public short? IeshTimer { get; set; }
        public string IeshFiller { get; set; }
    }
}
