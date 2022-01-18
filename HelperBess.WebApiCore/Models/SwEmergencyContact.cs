#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwEmergencyContact
    {
        public int SwemergencyContactId { get; set; }
        public int? SupportWorkerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Relationship { get; set; }
        public bool? InformationConsent { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
