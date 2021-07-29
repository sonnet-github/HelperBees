using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerReligion
    {
        public int SupportWorkerReligionId { get; set; }
        public int? SupportWorkerId { get; set; }
        public int? ReligionId { get; set; }

        public virtual Religion Religion { get; set; }
        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
