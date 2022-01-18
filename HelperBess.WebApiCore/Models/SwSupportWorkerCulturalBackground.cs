#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerCulturalBackground
    {
        public int SupportWorkerCulturalBackgroundId { get; set; }
        public int? SupportWorkerId { get; set; }
        public int? CulturalBackgroundId { get; set; }

        public virtual CulturalBackground CulturalBackground { get; set; }
        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
