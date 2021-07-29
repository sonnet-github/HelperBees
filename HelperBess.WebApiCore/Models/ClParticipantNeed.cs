using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClParticipantNeed
    {
        public int ParticipantNeedsId { get; set; }
        public int? ParticipantId { get; set; }
        public int? ParticipantNeedsAreaId { get; set; }
        public string Description { get; set; }

        public virtual ClParticipant Participant { get; set; }
        public virtual ClParticipantNeedsArea ParticipantNeedsArea { get; set; }
    }
}
