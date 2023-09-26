using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class User
    {
        public User()
        {
            UserGroups = new HashSet<UserGroup>();
            UserRights = new HashSet<UserRight>();
        }

        public string UserId { get; set; }
        public string Ulast { get; set; }
        public string Ufrist { get; set; }
        public string Utitle { get; set; }
        public string UPasscode { get; set; }
        public int? NoofLogin { get; set; }
        public bool? ExpiredPasscodeQ { get; set; }
        public bool? InactiveQ { get; set; }
        public int? LastPasscodeChange { get; set; }
        public string UserInfo { get; set; }
        public byte[] EncryptPassword { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }

        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<UserRight> UserRights { get; set; }
    }
}
