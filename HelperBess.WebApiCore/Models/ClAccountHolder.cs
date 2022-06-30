using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClAccountHolder
    {
        public ClAccountHolder()
        {
            ClAccountHolderProfiles = new HashSet<ClAccountHolderProfile>();
            ClParticipants = new HashSet<ClParticipant>();
            ClEmailPreference = new HashSet<CLEmailPreference>();
        }

        public int AccountHolderId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int? FailedLoginCount { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? StatusId { get; set; }
        public bool? Locked { get; set; }
        public bool? Active { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<ClAccountHolderProfile> ClAccountHolderProfiles { get; set; }
        public virtual ICollection<ClParticipant> ClParticipants { get; set; }
        public virtual ICollection<CLEmailPreference> ClEmailPreference { get; set; }
    }
}
