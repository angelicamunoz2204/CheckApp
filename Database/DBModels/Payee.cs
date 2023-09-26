using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class Payee
    {
        public string Spare1 { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string PayAddress1 { get; set; }
        public string PayAddress2 { get; set; }
        public string PayAddress3 { get; set; }
        public string PayAddress4 { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string CompanyZip { get; set; }
        public string PayeeId { get; set; }
        public int? FontId { get; set; }
        public string AdditionalRef { get; set; }
        public string CountryPhone { get; set; }
        public string PhoneNumber { get; set; }
        public string Address5 { get; set; }
        public string PayorId { get; set; }
        public string ReceivingDfiid { get; set; }
        public string DfiaccountNumber { get; set; }
        public string ReceivingCompanyName { get; set; }
        public string DefaultDiscretionary { get; set; }
        public string TypeOfAccount { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Filler1 { get; set; }
    }
}
