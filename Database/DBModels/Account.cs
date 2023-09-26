using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class Account
    {
        public string BankId { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string FontId { get; set; }
        public string Mask { get; set; }
        public string AccountNumber { get; set; }
        public string PayorId { get; set; }
        public string Filler1 { get; set; }
        public string LineAddr1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string CheckType { get; set; }
        public string Laguage { get; set; }
        public decimal? FirstCheckNo { get; set; }
        public string CheckTypf { get; set; }
        public string BranchId { get; set; }
        public int? NextChequeNo { get; set; }
        public string CheckbookId { get; set; }
        public short? ProjectKey { get; set; }
        public string Filler2 { get; set; }
    }
}
