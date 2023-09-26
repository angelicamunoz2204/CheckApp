using System;
using System.Collections.Generic;

#nullable disable

namespace CheckApp.Database.DBModels
{
    public partial class EventsSource
    {
        public int DatabaseId { get; set; }
        public string DatabaseName { get; set; }
    }
}
