using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckApp.DTO
{
    public class HeaderDTO
    {
        public string checkNumber { get; set; }
        public string bankId { get; set; }
        public string bankName { get; set; }
        public string bankAddress1 { get; set; }
        public string bankAddress2 { get; set; }
        public string accountId { get; set; }
        public string currencyId { get; set; }
        public string checkDate { get; set; }
        public string payeeId { get; set; }
        public string payeeName1 { get; set; }
        public string payeeName2 { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string address4 { get; set; }
        public string address5 { get; set; }
        public string checkAmount { get; set; }
        public string payorId { get; set; }
        public string amountString { get; set; }
        public string templateId { get; set; }
    }
}