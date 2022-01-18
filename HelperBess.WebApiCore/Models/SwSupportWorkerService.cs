#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerService
    {
        public int SupportWorkerServiceId { get; set; }
        public int? SupportWorkerId { get; set; }
        public int? ServiceId { get; set; }

        public virtual SwService Service { get; set; }
        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
