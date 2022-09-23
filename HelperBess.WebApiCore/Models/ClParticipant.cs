using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClParticipant
    {
        public ClParticipant()
        {
            ClEmergencyContacts = new HashSet<ClEmergencyContact>();
            ClHouseholdDetails = new HashSet<ClHouseholdDetail>();
            ClOtherContacts = new HashSet<ClOtherContact>();
            ClParticipantCulturalBackgrounds = new HashSet<ClParticipantCulturalBackground>();
            ClParticipantInterests = new HashSet<ClParticipantInterest>();
            ClParticipantLanguages = new HashSet<ClParticipantLanguage>();
            ClParticipantMedicationInformations = new HashSet<ClParticipantMedicationInformation>();
            ClParticipantMedications = new HashSet<ClParticipantMedication>();
            ClParticipantNeeds = new HashSet<ClParticipantNeed>();
            ClParticipantReligions = new HashSet<ClParticipantReligion>();
            ClPaymentDetails = new HashSet<ClPaymentDetail>();
            ClSocialNeedsGoals = new HashSet<ClSocialNeedsGoal>();
            Jobs = new HashSet<Job>();
        }

        public int ParticpantId { get; set; }
        public int? AccountHolderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string GenderOther { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthdate { get; set; }
        public string EmailAddress { get; set; }
        public string AddressStreet { get; set; }
        public string AddressPostcode { get; set; }
        public string AddressSuburb { get; set; }
        public string AddressState { get; set; }
        public bool? DangerContactAccept { get; set; }
        public bool? EmergencyContactAccept { get; set; }
        public string MedicalNeedsGoals { get; set; }


        public virtual ClAccountHolder AccountHolder { get; set; }
        public virtual ICollection<ClEmergencyContact> ClEmergencyContacts { get; set; }
        public virtual ICollection<ClHouseholdDetail> ClHouseholdDetails { get; set; }
        public virtual ICollection<ClOtherContact> ClOtherContacts { get; set; }
        public virtual ICollection<ClParticipantCulturalBackground> ClParticipantCulturalBackgrounds { get; set; }
        public virtual ICollection<ClParticipantInterest> ClParticipantInterests { get; set; }
        public virtual ICollection<ClParticipantLanguage> ClParticipantLanguages { get; set; }
        public virtual ICollection<ClParticipantMedicationInformation> ClParticipantMedicationInformations { get; set; }
        public virtual ICollection<ClParticipantMedication> ClParticipantMedications { get; set; }
        public virtual ICollection<ClParticipantNeed> ClParticipantNeeds { get; set; }
        public virtual ICollection<ClParticipantReligion> ClParticipantReligions { get; set; }
        public virtual ICollection<ClPaymentDetail> ClPaymentDetails { get; set; }
        public virtual ICollection<ClSocialNeedsGoal> ClSocialNeedsGoals { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
