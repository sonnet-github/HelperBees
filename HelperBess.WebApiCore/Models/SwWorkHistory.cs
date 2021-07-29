using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwWorkHistory
    {
        public int WorkHistoryId { get; set; }
        public int? SupportWorkerId { get; set; }
        public string JobTitle { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
