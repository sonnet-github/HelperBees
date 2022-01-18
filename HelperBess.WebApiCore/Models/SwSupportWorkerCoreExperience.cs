#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerCoreExperience
    {
        public int SupportWorkerCoreExperienceId { get; set; }
        public int? SupportWorkerId { get; set; }
        public int? CoreExperienceId { get; set; }

        public virtual SwCoreExperience CoreExperience { get; set; }
        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
