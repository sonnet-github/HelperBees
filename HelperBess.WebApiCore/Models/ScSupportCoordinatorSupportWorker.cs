#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ScSupportCoordinatorSupportWorker
    {
        public int UpportCoordinatorSupportWorkerId { get; set; }
        public int? SupportCoordinatorId { get; set; }
        public string Status { get; set; }
        public int? SupportWorkerId { get; set; }
        public virtual ScSupportCoordinator SupportCoordinator { get; set; }
    }
}
