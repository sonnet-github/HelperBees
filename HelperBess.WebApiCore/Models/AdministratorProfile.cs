using System;

namespace HelperBess.WebApiCore.Models
{
    public partial class AdministratorProfile
    {
        public int AdministratorProfileId { get; set; }
        public int? AdministratorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Administrator Administrator { get; set; }
    }
}