#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerAhdetail
    {
        public int SupportWorkerAhdetailsId { get; set; }
        public int? SupportWorkerId { get; set; }
        public int? OccupationalTherapyExperience { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
