using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class FtptransProf
    {
        public string ProfileId { get; set; }
        public string UserId { get; set; }
        public string Password1 { get; set; }
        public string ScriptName { get; set; }
        public string ServerName { get; set; }
        public string Logname { get; set; }
        public string File2Send { get; set; }
        public string File2Receive { get; set; }
        public string PacingDelay { get; set; }
        public string CommandName { get; set; }
        public string Description { get; set; }
        public string FillerFtpsection { get; set; }
        public int? LastProcessingDate { get; set; }
        public int? StartAt { get; set; }
        public string CryInitProcedure { get; set; }
        public string CryRunProcedure { get; set; }
        public string CryFilePath { get; set; }
        public string CryUserId { get; set; }
        public string CryLogFileName { get; set; }
        public string FillerEncryptionSect { get; set; }
        public string DateStampM { get; set; }
        public string TimeStampM { get; set; }
    }
}
