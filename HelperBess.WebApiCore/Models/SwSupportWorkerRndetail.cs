#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerRndetail
    {
        public int SupportWorkerRndetailsId { get; set; }
        public int? SupportWorkerId { get; set; }
        public bool? OnePlusYearsConfirmation { get; set; }
        public int? YearsExperience { get; set; }
        public bool? NursingMidwiferyReqConfirm { get; set; }
        public bool? AhpraregistrationActiveConfirm { get; set; }
        public bool? ConfirmNoComplaints { get; set; }
        public string ComplaintDetails { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
