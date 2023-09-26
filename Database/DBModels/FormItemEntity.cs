using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class FormItemEntity
    {
        public short EntityId { get; set; }
        public string Description { get; set; }
        public short? Relationship { get; set; }
    }
}
