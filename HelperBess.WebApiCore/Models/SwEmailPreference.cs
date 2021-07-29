using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwEmailPreference
    {
        public int EmailPreferencesId { get; set; }
        public int? SupportWorkerId { get; set; }
        public bool? Agreements { get; set; }
        public bool? PostJobs { get; set; }
        public bool? Messages { get; set; }
        public bool? Timesheets { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
