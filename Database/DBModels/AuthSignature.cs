using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class AuthSignature
    {
        public int FontId { get; set; }
        public string SignatureDescription { get; set; }
        public bool? ActiveQ { get; set; }
        public string PrimaryOrSecondary { get; set; }
        public decimal? LowValueRange { get; set; }
        public decimal? HighValueRange { get; set; }
        public string SignatureAccompanyMe { get; set; }
        public string ActivationChars { get; set; }
        public string Initials { get; set; }
        public string UserCode { get; set; }
        public short ProjectKey { get; set; }
        public string UserId { get; set; }
        public bool? RecordCreatedModifie { get; set; }
        public bool? Waiting4ReplicationQ { get; set; }
        public string Spare1 { get; set; }
    }
}
