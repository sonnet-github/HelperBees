using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwInsuranceDeclaration
    {
        public int InsuranceDeclarationId { get; set; }
        public int? SupportWorkerId { get; set; }
        public DateTime? DateOfFirstExperience { get; set; }
        public bool? NewToIndustry { get; set; }
        public bool? Bankruptcy { get; set; }
        public string BankruptcyDetails { get; set; }
        public bool? Fraud { get; set; }
        public string FraudDetails { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
