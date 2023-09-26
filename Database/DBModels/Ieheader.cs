using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class Ieheader
    {
        public string Purpose { get; set; }
        public string GeneralCode { get; set; }
        public string RecordType { get; set; }
        public bool? IeihGenerateCheckNum { get; set; }
        public string IeihGeneralDescripti { get; set; }
        public string IeihFilter { get; set; }
        public short? IeihEngineVersion { get; set; }
        public bool? IeihOmitBlanksQ { get; set; }
        public short? ProjectKey { get; set; }
        public short? IehPaddingChar4Expor { get; set; }
        public short? IeihDivideMultiplyAm { get; set; }
        public bool? IeihSingleRecDetailH { get; set; }
        public string IeihAppl2run { get; set; }
        public string Ieihpath { get; set; }
        public bool? IeihselectedQ { get; set; }
        public string IeihfieldDelimiter { get; set; }
        public string IeihModeManAuto { get; set; }
        public short? Timer { get; set; }
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public string Column5 { get; set; }
        public string Column6 { get; set; }
        public string Column7 { get; set; }
        public string Column8 { get; set; }
    }
}
