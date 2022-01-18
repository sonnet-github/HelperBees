#nullable disable

using System;

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerProfile
    {
        public int SupportWorkerProfileId { get; set; }
        public int? SupportWorkerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? LegalName { get; set; }
        public string FriendlyName { get; set; }
        public string Bio { get; set; }
        public string CompanyPartnershipDetails { get; set; }
        public string CompanyName { get; set; }
        public string PartnershipName { get; set; }
        public int? InvoiceType { get; set; }
        public string ProfilePhotoURL { get; set; }
        public string Sex { get; set; }
        public string SexOther { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public string ResAddrUnitNumber { get; set; }
        public string ResAddrStreet { get; set; }
        public string ResAddrSuburb { get; set; }
        public string ResAddrState { get; set; }
        public string ResAddrCountry { get; set; }
        public bool PostAddrSameAsResAddr { get; set; }
        public string PostAddrUnitNumber { get; set; }
        public string PostAddrStreet { get; set; }
        public string PostAddrSuburb { get; set; }
        public string PostAddrState { get; set; }
        public string PostAddrCountry { get; set; }
        public string ABN { get; set; }
        public string InterestsAndHobbies { get; set; }
        public string Personality { get; set; }
        public string PersonalityAdditional { get; set; }
        public bool PetFriendly { get; set; }
        public bool NonSmoker { get; set; }
        public string PreferToWorkWith { get; set; }
        public int? AHRPARegistrationNumber { get; set; }
        public DateTime AHRPAExpiryDate { get; set; }
        public bool AHPRARegistrationActiveConfirm { get; set; }
        public bool ProvideTransportServices { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
