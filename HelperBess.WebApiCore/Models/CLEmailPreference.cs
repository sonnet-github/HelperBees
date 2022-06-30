using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperBess.WebApiCore.Models
{
    public partial class CLEmailPreference
    {
        public int CLEmailPreferencesId { get; set; }
        public int? AccountHolderId { get; set; }
        public bool? Agreements { get; set; }
        public bool? PostJobs { get; set; }
        public bool? Messages { get; set; }
        public bool? Timesheets { get; set; }

        public virtual ClAccountHolder ClAccountHolder { get; set; }
    }
}
