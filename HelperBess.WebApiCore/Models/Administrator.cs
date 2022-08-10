using System;

namespace HelperBess.WebApiCore.Models
{
    public partial class Administrator
    {
        public int AdministratorId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? StatusId { get; set; }
        public bool? Active { get; set; }

        public virtual Status Status { get; set; }
    }
}
