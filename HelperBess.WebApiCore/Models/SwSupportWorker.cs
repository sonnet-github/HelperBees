using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorker
    {
        public SwSupportWorker()
        {
            ChangeLogs = new HashSet<ChangeLog>();
            JobAssignments = new HashSet<JobAssignment>();
            SwAvailabilities = new HashSet<SwAvailability>();
            SwAvailabilityDetails = new HashSet<SwAvailabilityDetail>();
            SwClients = new HashSet<SwClient>();
            SwEducations = new HashSet<SwEducation>();
            SwEmailPreferences = new HashSet<SwEmailPreference>();
            SwEmergencyContacts = new HashSet<SwEmergencyContact>();
            SwInsuranceDeclarations = new HashSet<SwInsuranceDeclaration>();
            SwMandatoryChecks = new HashSet<SwMandatoryCheck>();
            SwReferences = new HashSet<SwReference>();
            SwSupportWorkerAdditionalTrainings = new HashSet<SwSupportWorkerAdditionalTraining>();
            SwSupportWorkerAhdetails = new HashSet<SwSupportWorkerAhdetail>();
            SwSupportWorkerBankAccounts = new HashSet<SwSupportWorkerBankAccount>();
            SwSupportWorkerCoreExperiences = new HashSet<SwSupportWorkerCoreExperience>();
            SwSupportWorkerCulturalBackgrounds = new HashSet<SwSupportWorkerCulturalBackground>();
            SwSupportWorkerLanguages = new HashSet<SwSupportWorkerLanguage>();
            SwSupportWorkerOtherQualifications = new HashSet<SwSupportWorkerOtherQualification>();
            SwSupportWorkerOtherTrainings = new HashSet<SwSupportWorkerOtherTraining>();
            SwSupportWorkerPcdetails = new HashSet<SwSupportWorkerPcdetail>();
            SwSupportWorkerPresigns = new HashSet<SwSupportWorkerPresign>();
            SwSupportWorkerProfiles = new HashSet<SwSupportWorkerProfile>();
            SwSupportWorkerQualifications = new HashSet<SwSupportWorkerQualification>();
            SwSupportWorkerReligions = new HashSet<SwSupportWorkerReligion>();
            SwSupportWorkerRndetails = new HashSet<SwSupportWorkerRndetail>();
            SwSupportWorkerServices = new HashSet<SwSupportWorkerService>();
            SwTimesheets = new HashSet<SwTimesheet>();
            SwTransportInfos = new HashSet<SwTransportInfo>();
            SwWorkHistories = new HashSet<SwWorkHistory>();
            SwloginAudits = new HashSet<SwloginAudit>();
            CLEmailPreference = new HashSet<CLEmailPreference>();
        }

        public int SupportWorkerId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int? FailedLoginCount { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? StatusId { get; set; }
        public bool? Locked { get; set; }
        public bool? Active { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<ChangeLog> ChangeLogs { get; set; }
        public virtual ICollection<JobAssignment> JobAssignments { get; set; }
        public virtual ICollection<SwAvailability> SwAvailabilities { get; set; }
        public virtual ICollection<SwAvailabilityDetail> SwAvailabilityDetails { get; set; }
        public virtual ICollection<SwClient> SwClients { get; set; }
        public virtual ICollection<SwEducation> SwEducations { get; set; }
        public virtual ICollection<SwEmailPreference> SwEmailPreferences { get; set; }
        public virtual ICollection<SwEmergencyContact> SwEmergencyContacts { get; set; }
        public virtual ICollection<SwInsuranceDeclaration> SwInsuranceDeclarations { get; set; }
        public virtual ICollection<SwMandatoryCheck> SwMandatoryChecks { get; set; }
        public virtual ICollection<SwReference> SwReferences { get; set; }
        public virtual ICollection<SwSupportWorkerAdditionalTraining> SwSupportWorkerAdditionalTrainings { get; set; }
        public virtual ICollection<SwSupportWorkerAhdetail> SwSupportWorkerAhdetails { get; set; }
        public virtual ICollection<SwSupportWorkerBankAccount> SwSupportWorkerBankAccounts { get; set; }
        public virtual ICollection<SwSupportWorkerCoreExperience> SwSupportWorkerCoreExperiences { get; set; }
        public virtual ICollection<SwSupportWorkerCulturalBackground> SwSupportWorkerCulturalBackgrounds { get; set; }
        public virtual ICollection<SwSupportWorkerLanguage> SwSupportWorkerLanguages { get; set; }
        public virtual ICollection<SwSupportWorkerOtherQualification> SwSupportWorkerOtherQualifications { get; set; }
        public virtual ICollection<SwSupportWorkerOtherTraining> SwSupportWorkerOtherTrainings { get; set; }
        public virtual ICollection<SwSupportWorkerPcdetail> SwSupportWorkerPcdetails { get; set; }
        public virtual ICollection<SwSupportWorkerPresign> SwSupportWorkerPresigns { get; set; }
        public virtual ICollection<SwSupportWorkerProfile> SwSupportWorkerProfiles { get; set; }
        public virtual ICollection<SwSupportWorkerQualification> SwSupportWorkerQualifications { get; set; }
        public virtual ICollection<SwSupportWorkerReligion> SwSupportWorkerReligions { get; set; }
        public virtual ICollection<SwSupportWorkerRndetail> SwSupportWorkerRndetails { get; set; }
        public virtual ICollection<SwSupportWorkerService> SwSupportWorkerServices { get; set; }
        public virtual ICollection<SwTimesheet> SwTimesheets { get; set; }
        public virtual ICollection<SwTransportInfo> SwTransportInfos { get; set; }
        public virtual ICollection<SwWorkHistory> SwWorkHistories { get; set; }
        public virtual ICollection<SwloginAudit> SwloginAudits { get; set; }
        public virtual ICollection<CLEmailPreference> CLEmailPreference { get; set; }
    }
}
