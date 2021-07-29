using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class JobTime
    {
        public int JobTimesId { get; set; }
        public int? JobId { get; set; }
        public string DayOfWeek { get; set; }
        public string TimeOfDay { get; set; }

        public virtual Job Job { get; set; }
    }
}
