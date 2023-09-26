using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class SynLinkChildDoc
    {
        public string SlAppl { get; set; }
        public string LayoutId { get; set; }
        public string SlformId { get; set; }
        public string SlPaperSize { get; set; }
        public string SlTray { get; set; }
        public string SlOrientation { get; set; }
        public string SlUsePurpose { get; set; }
        public short? SlLinesXdoc { get; set; }
        public short ProjectKey { get; set; }
        public string SlInitString { get; set; }
        public bool? SlOmitInit { get; set; }
        public short? SlDocsXpage { get; set; }
        public string SlMode { get; set; }
        public string SlExportId { get; set; }
        public string SlTempFile { get; set; }
        public string SlPrinterSecFeature { get; set; }
        public string SlAdditionalFlags { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public string Desc3 { get; set; }
    }
}
