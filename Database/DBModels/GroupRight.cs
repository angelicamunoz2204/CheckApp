using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class GroupRight
    {
        public string GroupId { get; set; }
        public string RightId { get; set; }
        public bool? GrAssignedQ { get; set; }
    }
}
