#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerOtherTraining
    {
        public int SupportWorkerOtherTrainingId { get; set; }
        public int? SupportWorkerId { get; set; }
        public string OtherQualification { get; set; }
        public string Certificate { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
