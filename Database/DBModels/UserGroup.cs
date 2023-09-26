using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class UserGroup
    {
        public string GroupId { get; set; }
        public string UserId { get; set; }
        public bool? UgAssignedQ { get; set; }

        public virtual User User { get; set; }
    }
}
