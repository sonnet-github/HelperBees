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
        public bool? Circumstance { get; set; }
        public string CircumstanceDetails { get; set; }
        public bool? Insurance { get; set; }
        public string InsuranceDetails { get; set; }
        public bool? Workers { get; set; }
        public string WorkersDetails { get; set; }
        public bool? MMPI { get; set; }
        public string MMPIDetails { get; set; }
        public bool? Liability { get; set; }
        public string LiabilityDetails { get; set; }
        public bool? Accident { get; set; }
        public string AccidentsDetails { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
