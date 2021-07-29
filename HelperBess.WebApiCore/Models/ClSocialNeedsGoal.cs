using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClSocialNeedsGoal
    {
        public int SocialNeedsGoalsId { get; set; }
        public int? ParticipantId { get; set; }
        public string SocialNeedsDescription { get; set; }

        public virtual ClParticipant Participant { get; set; }
    }
}
