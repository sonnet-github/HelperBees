using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClPaymentDetail
    {
        public int PaymentDetailsId { get; set; }
        public int? ParticipantId { get; set; }
        public bool? GovernmentFunding { get; set; }
        public string FundingType { get; set; }
        public string FundingTypeOther { get; set; }
        public string PlanType { get; set; }
        public string HomeCarePackageProviderName { get; set; }
        public string OtherFundingDocument1 { get; set; }
        public string OtherFundingDocument2 { get; set; }
        public string OtherFundingDocument3 { get; set; }
        public string PaymentType { get; set; }
        public bool? CreditCardAuthority { get; set; }
        public string Ccname { get; set; }
        public int? Ccnumber { get; set; }
        public DateTime? CcexpiryDate { get; set; }
        public int? Cccvv { get; set; }
        public string BankAccountName { get; set; }
        public string BankName { get; set; }
        public int? Bsb { get; set; }
        public int? AccountNumber { get; set; }
        public string DirectDebitAuthorisationForm { get; set; }

        public virtual ClParticipant Participant { get; set; }
    }
}
