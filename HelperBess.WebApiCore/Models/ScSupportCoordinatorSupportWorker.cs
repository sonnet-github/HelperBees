using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ScSupportCoordinatorSupportWorker
    {
        public int UpportCoordinatorSupportWorkerId { get; set; }
        public int? SupportCoordinatorId { get; set; }
        public string Status { get; set; }

        public virtual ScSupportCoordinator SupportCoordinator { get; set; }
    }
}
