using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class CbooksCbooksReq
    {
        public string AccountNo { get; set; }
        public string BankId { get; set; }
        public short Checks2Print { get; set; }
        public string TypeAccount { get; set; }
        public string CheckStatus { get; set; }
        public string CurrencyId { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public DateTime? PrintedDateTime { get; set; }
        public string UserId { get; set; }
        public string RoutingTransitInfo { get; set; }
        public bool? FlgprintNotAllowed { get; set; }
        public long? BatchId { get; set; }
        public int? RecordNumber { get; set; }
        public string LayoutId { get; set; }
        public string Applicat { get; set; }
        public int InitialCheckNo { get; set; }
        public string CheckLayoutNo { get; set; }
        public string Source { get; set; }
        public string CustNameLegal { get; set; }
        public string CustName1 { get; set; }
        public string CustName2 { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Addr4 { get; set; }
        public string Phone { get; set; }
        public string ChkbookDescript { get; set; }
        public string Email { get; set; }
        public string BranchId { get; set; }
        public string RequestTimeUsrAlph5 { get; set; }
        public string OperationDateTime { get; set; }
        public decimal? UserVal1 { get; set; }
        public decimal? UserVal2 { get; set; }
        public decimal? UserVal3 { get; set; }
        public decimal? UserVal4 { get; set; }
        public decimal? UserVal5 { get; set; }
        public bool? InhibitPrintFlag { get; set; }
        public DateTime? Processtime { get; set; }
        public string CustomerName3 { get; set; }
        public string ReprintControlFlag { get; set; }
        public int? EndCheckNo { get; set; }
        public string Filler { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public string LocationCode { get; set; }
        public long? EndChkNoCompute { get; set; }
        public decimal? PriceStyle1 { get; set; }
        public decimal? PriceStyle2 { get; set; }
        public decimal? PriceStyle3 { get; set; }
        public string SelectedStyle { get; set; }
        public string BaseCurrencyId { get; set; }
        public decimal? BaseCurrencyPrice { get; set; }
        public decimal? CheckBookPrice { get; set; }
        public decimal? CurrencyIdexchange { get; set; }
        public DateTime? AccessedTime { get; set; }
        public string FormName { get; set; }
        public string Trtype { get; set; }
    }
}
