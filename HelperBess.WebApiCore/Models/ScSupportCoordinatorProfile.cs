#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ScSupportCoordinatorProfile
    {
        public int SupportCoordinatorProfileId { get; set; }
        public int? SupportCoordinatorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ScSupportCoordinator SupportCoordinator { get; set; }
    }
}
