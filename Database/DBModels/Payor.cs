using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class Payor
    {
        public short ProjectKey { get; set; }
        public int? MerchantId { get; set; }
        public string FtpProfile { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string PayAddress1 { get; set; }
        public string PayAddress2 { get; set; }
        public string PayAddress3 { get; set; }
        public string PayAddress4 { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string CompanyZip { get; set; }
        public string Payorid { get; set; }
        public int? FontId { get; set; }
        public string Irscode { get; set; }
        public string OriginatingDfiid { get; set; }
        public string Dfiachcdv { get; set; }
        public string OdfiInmediateName { get; set; }
        public string InmediateOrigin { get; set; }
        public string Filler2 { get; set; }
        public bool? Achtype7Q { get; set; }
        public int? Achtype7DetailsNumbers { get; set; }
        public int? Font1 { get; set; }
        public int? Font2 { get; set; }
        public int? Font3 { get; set; }
        public int? Font4 { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public string Desc3 { get; set; }
    }
}
