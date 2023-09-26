using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class Synonym
    {
        public string Application { get; set; }
        public string UserCodeDocType { get; set; }
        public string LayoutId { get; set; }
        public short? VertMicradj { get; set; }
        public short? HorizMicradj { get; set; }
        public short ProjectKey { get; set; }
        public string DetailStyle { get; set; }
        public string ExportFileCode { get; set; }
        public short? DocsXpage { get; set; }
        public string DescripSyn { get; set; }
        public string ScreenCode { get; set; }
        public bool? IntegratedPrintEngin { get; set; }
        public string PrintEnginePath { get; set; }
        public string EndofBatchPathS { get; set; }
        public string EobName { get; set; }
        public string PostProcessing { get; set; }
        public string Filler { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
    }
}
