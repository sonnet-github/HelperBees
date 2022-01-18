#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerLanguage
    {
        public int SupportWorkerLanguageId { get; set; }
        public int? SupportWorkerId { get; set; }
        public int? LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
