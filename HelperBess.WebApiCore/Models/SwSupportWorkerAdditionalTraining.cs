using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerAdditionalTraining
    {
        public int SupportWorkerAdditionalTrainingId { get; set; }
        public int? SupportWorkerId { get; set; }
        public bool? Cprcertificate { get; set; }
        public string Cprupload { get; set; }
        public DateTime? CpracquiredDate { get; set; }
        public DateTime? CprexpiryDate { get; set; }
        public bool? FirstAidCertificate { get; set; }
        public string FirstAidUpload { get; set; }
        public DateTime? FirstAidAcquiredDate { get; set; }
        public DateTime? FirstAidExpiryDate { get; set; }
        public bool? Ndiswomcertificate { get; set; }
        public string Ndiswomupload { get; set; }
        public DateTime? NdiswomacquiredDate { get; set; }
        public DateTime? NdiswomexpiryDate { get; set; }
        public bool? Covidicc { get; set; }
        public string Covidiccupload { get; set; }
        public DateTime? CovidiccacquiredDate { get; set; }
        public DateTime? CovidiccexpiryDate { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
