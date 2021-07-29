using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class Religion
    {
        public Religion()
        {
            ClParticipantReligions = new HashSet<ClParticipantReligion>();
            SwSupportWorkerReligions = new HashSet<SwSupportWorkerReligion>();
        }

        public int ReligionId { get; set; }
        public string Religion1 { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual ICollection<ClParticipantReligion> ClParticipantReligions { get; set; }
        public virtual ICollection<SwSupportWorkerReligion> SwSupportWorkerReligions { get; set; }
    }
}
