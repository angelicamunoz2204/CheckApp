using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class AchfileHeadRec
    {
        public string RecordTypeCode { get; set; }
        public short? PriorityCode { get; set; }
        public string InmediateDestination { get; set; }
        public string InmediateOrigin { get; set; }
        public string FileCreationDate { get; set; }
        public string FileCreationTime { get; set; }
        public string FileIdmodifier { get; set; }
        public string RecordSize { get; set; }
        public string BlockingFactor { get; set; }
        public string FormatCode { get; set; }
        public string InmediateDestinatioo { get; set; }
        public string InmediateOriginName { get; set; }
        public string ReferenceCode { get; set; }
    }
}
