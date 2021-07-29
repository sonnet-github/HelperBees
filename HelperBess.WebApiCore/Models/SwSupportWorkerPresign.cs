using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerPresign
    {
        public int SupportWorkerPresignId { get; set; }
        public int? SupportWorkerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Location { get; set; }
        public string WorkHours { get; set; }
        public string MobileNumber { get; set; }
        public string HowHear { get; set; }
        public bool? SensitiveDataConfirm { get; set; }
        public bool? MarketingOptin { get; set; }
        public bool? TermsAndConditionsConfirm { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
