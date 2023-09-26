using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class ChecksD1
    {
        public long BatchId { get; set; }
        public int RecordNo { get; set; }
        public string CheckNo { get; set; }
        public string BankId { get; set; }
        public string BankAccountNumber { get; set; }
        public int? CheckDate { get; set; }
        public string InvoiceNumber { get; set; }
        public int? InvoiceDate { get; set; }
        public string VoucherNo { get; set; }
        public int? Voucherdate { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? DiscountTaken { get; set; }
        public decimal? NetAmount { get; set; }
        public string ConceptOrdescription { get; set; }
        public string CurrencyId { get; set; }
        public string TypeOfAccount { get; set; }
        public string UserString122 { get; set; }
        public short SeqNoThisDoc { get; set; }
        public decimal? DebitGl { get; set; }
        public decimal? CreditGl { get; set; }
        public string AditionalRefGl { get; set; }
        public string OperationType { get; set; }
        public decimal? EarnedDeductAmtMtd { get; set; }
        public decimal? UnitsHoursQ { get; set; }
        public decimal? EarnedDeductedAmtYtd { get; set; }
        public bool? ProllPreTxLog { get; set; }
        public string TriggerMultistub { get; set; }
        public decimal? EarnDeductiRate { get; set; }
        public string LongDescription { get; set; }
        public decimal? CalculateNetAmount { get; set; }
        public string Descript1 { get; set; }
        public string Descript2 { get; set; }
        public string Descript3 { get; set; }
        public string Descript4 { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value2 { get; set; }
        public decimal? Value3 { get; set; }
        public decimal? Value4 { get; set; }
        public DateTime? StubDate { get; set; }
        public DateTime? StubDate1 { get; set; }
        public string Descript5 { get; set; }
        public string Descript6 { get; set; }
        public string Descript7 { get; set; }
        public string Descript8 { get; set; }
        public string Descript9 { get; set; }
        public string Descript10 { get; set; }
        public string Descript11 { get; set; }
        public string Descript12 { get; set; }
        public string Descript13 { get; set; }
        public string Descript14 { get; set; }
        public string Descript15 { get; set; }
        public decimal? Value5 { get; set; }
        public decimal? Value6 { get; set; }
        public decimal? Value7 { get; set; }
        public decimal? Value8 { get; set; }
        public decimal? Value9 { get; set; }
        public decimal? Value10 { get; set; }
        public decimal? Value11 { get; set; }
        public decimal? Value12 { get; set; }
        public decimal? Value13 { get; set; }
        public decimal? Value14 { get; set; }
        public decimal? Value15 { get; set; }
        public decimal? Value16 { get; set; }
        public decimal? Value17 { get; set; }
        public decimal? Value18 { get; set; }
        public decimal? Value19 { get; set; }
        public decimal? Value20 { get; set; }

        public virtual BtchDet Batch { get; set; }
    }
}
