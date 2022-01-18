#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwReference
    {
        public int ReferenceId { get; set; }
        public int? SupportWorkerId { get; set; }
        public string ReferenceType { get; set; }
        public string Certificate { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobtitleOrRole { get; set; }
        public string BusinessOrEmployer { get; set; }
        public int? HowLongKnown { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
