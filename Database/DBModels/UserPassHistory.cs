using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class UserPassHistory
    {
        public string UserId { get; set; }
        public DateTime? PassDate { get; set; }
        public byte[] Password { get; set; }
        public long IdentityId { get; set; }
    }
}
