using System;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Models
{
    public partial class Administrator
    {
        public Administrator()
        {
            AdministratorProfiles = new HashSet<AdministratorProfile>();
            //AdminSupportWorkers = new HashSet<AdminSupportWorker>();
            //AdminAccountHolders = new HashSet<AdminAccountHolder>();
        }

        public int AdministratorId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? StatusId { get; set; }
        public bool? Active { get; set; }

        public virtual Status Status { get; set; }


        public virtual ICollection<AdministratorProfile> AdministratorProfiles { get; set; }

        public virtual ICollection<AdminSupportWorker> AdminSupportWorkers { get; set; }
        public virtual ICollection<AdminAccountHolder> AdminAccountHolders { get; set; }
    }
}