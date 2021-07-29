using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerPcdetail
    {
        public int SupportWorkerPcdetailsId { get; set; }
        public int? SupportWorkerId { get; set; }
        public bool? TwoPlusYearsConfirmation { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
