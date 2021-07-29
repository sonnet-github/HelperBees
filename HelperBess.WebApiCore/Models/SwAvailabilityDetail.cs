using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwAvailabilityDetail
    {
        public int AvailabilityDetailsId { get; set; }
        public int? SupportWorkerId { get; set; }
        public int? DayOfWeek { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
