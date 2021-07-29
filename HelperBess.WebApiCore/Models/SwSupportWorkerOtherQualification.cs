using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerOtherQualification
    {
        public int SupportWorkerOtherQualificationId { get; set; }
        public int? SupportWorkerId { get; set; }
        public int? ServiceGroupId { get; set; }
        public string OtherQualification { get; set; }
        public string Certificate { get; set; }

        public virtual SwServiceGroup ServiceGroup { get; set; }
        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
