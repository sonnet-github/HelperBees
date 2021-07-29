using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class Language
    {
        public Language()
        {
            ClParticipantLanguages = new HashSet<ClParticipantLanguage>();
            SwSupportWorkerLanguages = new HashSet<SwSupportWorkerLanguage>();
        }

        public int LanguageId { get; set; }
        public string Language1 { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual ICollection<ClParticipantLanguage> ClParticipantLanguages { get; set; }
        public virtual ICollection<SwSupportWorkerLanguage> SwSupportWorkerLanguages { get; set; }
    }
}
