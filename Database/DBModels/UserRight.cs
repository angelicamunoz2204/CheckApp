using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class UserRight
    {
        public string UserId { get; set; }
        public string RightId { get; set; }
        public bool? UrAssigned { get; set; }
        public string GroupId { get; set; }

        public virtual User User { get; set; }
    }
}
