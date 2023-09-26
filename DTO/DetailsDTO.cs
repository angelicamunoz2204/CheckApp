using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckApp.DTO
{
    public class DetailsDTO
    {
        public string checkNumber { get; set; }
        public string bankId { get; set; }
        public string bankAccount { get; set; }
        public string checkDate { get; set; }
        public string invoiceNumber { get; set; }
        public string invoiceDate { get; set; }
        public string voucherNumber { get; set; }
        public string voucherDate { get; set; }
        public string grossAmount { get; set; }
        public string discountAmount { get; set; }
        public string netAmount { get; set; }
        public string concept { get; set; }
        public string benefitDescription { get; set; }
    }
}