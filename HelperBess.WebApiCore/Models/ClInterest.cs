using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClInterest
    {
        public ClInterest()
        {
            ClParticipantInterests = new HashSet<ClParticipantInterest>();
        }

        public int InterestsId { get; set; }
        public string InterestsDescription { get; set; }

        public virtual ICollection<ClParticipantInterest> ClParticipantInterests { get; set; }
    }
}
