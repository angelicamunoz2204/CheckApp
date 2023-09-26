using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class Bank
    {
        public string BankId { get; set; }
        public string BankName { get; set; }
        public int? FontId { get; set; }
        public string DefAccountMask { get; set; }
        public string DefUserMicrValue { get; set; }
        public string MicrFont { get; set; }
        public string Filler1 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string BranchOfficeCode { get; set; }
        public string BankCode { get; set; }
        public string TransactFraction1 { get; set; }
        public string TransactFraction2 { get; set; }
        public string TransactFraction3 { get; set; }
        public string DefTransitMicr { get; set; }
        public int? LastCheckNo { get; set; }
        public bool? StampDuty { get; set; }
        public int? DutyStampFontId { get; set; }
        public short? ProjectKey { get; set; }
        public string Filler2 { get; set; }
        public bool? AddendaYesNo { get; set; }
        public int? AddendaNoLines { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public string Col5 { get; set; }

        public virtual MicrlineLayout MicrlineLayout { get; set; }
    }
}
