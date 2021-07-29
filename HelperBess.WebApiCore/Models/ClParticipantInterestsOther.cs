using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClParticipantInterestsOther
    {
        public int ParticipantInterestsOtherId { get; set; }
        public int? ParticipantId { get; set; }
        public string InterestDescription { get; set; }
    }
}
