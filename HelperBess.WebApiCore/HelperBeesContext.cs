using HelperBess.WebApiCore.IServices;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class HelperBeesContext : DbContext
    {
        private readonly IConfigurationService configuration;

        public HelperBeesContext(IConfigurationService configService)
        {
            configuration = configService;
        }

        public HelperBeesContext(DbContextOptions<HelperBeesContext> options, IConfigurationService configService)
            : base(options)
        {
            configuration = configService;
        }

        public virtual DbSet<ChangeLog> ChangeLogs { get; set; }
        public virtual DbSet<ClAccountHolder> ClAccountHolders { get; set; }
        public virtual DbSet<ClAccountHolderProfile> ClAccountHolderProfiles { get; set; }
        public virtual DbSet<ClEmergencyContact> ClEmergencyContacts { get; set; }
        public virtual DbSet<ClHouseholdDetail> ClHouseholdDetails { get; set; }
        public virtual DbSet<ClInterest> ClInterests { get; set; }
        public virtual DbSet<ClJobService> ClJobServices { get; set; }
        public virtual DbSet<ClOtherContact> ClOtherContacts { get; set; }
        public virtual DbSet<ClParticipant> ClParticipants { get; set; }
        public virtual DbSet<ClParticipantCulturalBackground> ClParticipantCulturalBackgrounds { get; set; }
        public virtual DbSet<ClParticipantInterest> ClParticipantInterests { get; set; }
        public virtual DbSet<ClParticipantInterestsOther> ClParticipantInterestsOthers { get; set; }
        public virtual DbSet<ClParticipantLanguage> ClParticipantLanguages { get; set; }
        public virtual DbSet<ClParticipantMedication> ClParticipantMedications { get; set; }
        public virtual DbSet<ClParticipantMedicationInformation> ClParticipantMedicationInformations { get; set; }
        public virtual DbSet<ClParticipantNeed> ClParticipantNeeds { get; set; }
        public virtual DbSet<ClParticipantNeedsArea> ClParticipantNeedsAreas { get; set; }
        public virtual DbSet<ClParticipantReligion> ClParticipantReligions { get; set; }
        public virtual DbSet<ClPaymentDetail> ClPaymentDetails { get; set; }
        public virtual DbSet<ClSocialNeedsGoal> ClSocialNeedsGoals { get; set; }
        public virtual DbSet<ClloginAudit> ClloginAudits { get; set; }
        public virtual DbSet<CulturalBackground> CulturalBackgrounds { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobAssignment> JobAssignments { get; set; }
        public virtual DbSet<JobMessageLog> JobMessageLogs { get; set; }
        public virtual DbSet<JobTime> JobTimes { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<ScSupportCoordinator> ScSupportCoordinators { get; set; }
        public virtual DbSet<ScSupportCoordinatorProfile> ScSupportCoordinatorProfiles { get; set; }
        public virtual DbSet<ScSupportCoordinatorSupportWorker> ScSupportCoordinatorSupportWorkers { get; set; }
        public virtual DbSet<ScimpersonisationLoginAudit> ScimpersonisationLoginAudits { get; set; }
        public virtual DbSet<ScloginAudit> ScloginAudits { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<SwAvailability> SwAvailabilities { get; set; }
        public virtual DbSet<SwAvailabilityDetail> SwAvailabilityDetails { get; set; }
        public virtual DbSet<SwClient> SwClients { get; set; }
        public virtual DbSet<SwCoreExperience> SwCoreExperiences { get; set; }
        public virtual DbSet<SwCoreExperienceField> SwCoreExperienceFields { get; set; }
        public virtual DbSet<SwEducation> SwEducations { get; set; }
        public virtual DbSet<SwEmailPreference> SwEmailPreferences { get; set; }
        public virtual DbSet<SwEmergencyContact> SwEmergencyContacts { get; set; }
        public virtual DbSet<SwInsuranceDeclaration> SwInsuranceDeclarations { get; set; }
        public virtual DbSet<SwInvoice> SwInvoices { get; set; }
        public virtual DbSet<SwInvoiceTemplate> SwInvoiceTemplates { get; set; }
        public virtual DbSet<SwMandatoryCheck> SwMandatoryChecks { get; set; }
        public virtual DbSet<SwQualification> SwQualifications { get; set; }
        public virtual DbSet<SwReference> SwReferences { get; set; }
        public virtual DbSet<SwService> SwServices { get; set; }
        public virtual DbSet<SwServiceGroup> SwServiceGroups { get; set; }
        public virtual DbSet<SwSupportWorker> SwSupportWorkers { get; set; }
        public virtual DbSet<SwSupportWorkerAdditionalTraining> SwSupportWorkerAdditionalTrainings { get; set; }
        public virtual DbSet<SwSupportWorkerAhdetail> SwSupportWorkerAhdetails { get; set; }
        public virtual DbSet<SwSupportWorkerBankAccount> SwSupportWorkerBankAccounts { get; set; }
        public virtual DbSet<SwSupportWorkerCoreExperience> SwSupportWorkerCoreExperiences { get; set; }
        public virtual DbSet<SwSupportWorkerCulturalBackground> SwSupportWorkerCulturalBackgrounds { get; set; }
        public virtual DbSet<SwSupportWorkerLanguage> SwSupportWorkerLanguages { get; set; }
        public virtual DbSet<SwSupportWorkerOtherQualification> SwSupportWorkerOtherQualifications { get; set; }
        public virtual DbSet<SwSupportWorkerOtherTraining> SwSupportWorkerOtherTrainings { get; set; }
        public virtual DbSet<SwSupportWorkerPcdetail> SwSupportWorkerPcdetails { get; set; }
        public virtual DbSet<SwSupportWorkerPresign> SwSupportWorkerPresigns { get; set; }
        public virtual DbSet<SwSupportWorkerProfile> SwSupportWorkerProfiles { get; set; }
        public virtual DbSet<SwSupportWorkerQualification> SwSupportWorkerQualifications { get; set; }
        public virtual DbSet<SwSupportWorkerReligion> SwSupportWorkerReligions { get; set; }
        public virtual DbSet<SwSupportWorkerRndetail> SwSupportWorkerRndetails { get; set; }
        public virtual DbSet<SwSupportWorkerService> SwSupportWorkerServices { get; set; }
        public virtual DbSet<SwTimesheet> SwTimesheets { get; set; }
        public virtual DbSet<SwTimesheetIncident> SwTimesheetIncidents { get; set; }
        public virtual DbSet<SwTimesheetStatus> SwTimesheetStatuses { get; set; }
        public virtual DbSet<SwTransportInfo> SwTransportInfos { get; set; }
        public virtual DbSet<SwWorkHistory> SwWorkHistories { get; set; }
        public virtual DbSet<SwloginAudit> SwloginAudits { get; set; }
        public virtual DbSet<SW_SupportWorkerUploadFiles> SW_SupportWorkerUploadFiles { get; set; }        public virtual DbSet<CLEmailPreference> CLEmailPreference { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

                //optionsBuilder.UseSqlServer("Server=DEO-DESKTOP;Database=HelperBees;Persist Security Info=True;Integrated Security=True;MultipleActiveResultSets=True;");

                //optionsBuilder.UseSqlServer("Server=LAPTOP-JQE05MHB\\SQLEXPRESS2019;Database=HelperBees;Persist Security Info=True;User ID=sa;Password=8232566;MultipleActiveResultSets=True;");
                
                optionsBuilder.UseSqlServer(configuration.DbConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<ChangeLog>(entity =>
            {
                entity.ToTable("ChangeLog");

                entity.HasIndex(e => e.SupportWorkerId, "ChangeLog_SupportWorkerId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.FieldChanged)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OldValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TableChanged)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.ChangeLogs)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangeLog_SW_SupportWorker");
            });

            modelBuilder.Entity<ClAccountHolder>(entity =>
            {
                entity.HasKey(e => e.AccountHolderId);

                entity.ToTable("CL_AccountHolder");

                entity.HasIndex(e => e.StatusId, "CL_AccountHolder_StatusId");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ClAccountHolders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_CL_AccountHolder_Status");
            });

            modelBuilder.Entity<ClAccountHolderProfile>(entity =>
            {
                entity.HasKey(e => e.AccountHolderProfileId);

                entity.ToTable("CL_AccountHolderProfile");

                entity.HasIndex(e => e.AccountHolderId, "CL_AccountHolderProfile_AccountHolderId");

                entity.Property(e => e.AddressPostcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddressStreet)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressSuburb)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GenderOther)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipToPersonNeedingSupport)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountHolder)
                    .WithMany(p => p.ClAccountHolderProfiles)
                    .HasForeignKey(d => d.AccountHolderId)
                    .HasConstraintName("FK_CL_AccountHolderProfile_CL_AccountHolder");
            });

            modelBuilder.Entity<ClEmergencyContact>(entity =>
            {
                entity.HasKey(e => e.EmergencyContactId);

                entity.ToTable("CL_EmergencyContact");

                entity.HasIndex(e => e.ParticipantId, "CL_EmergencyContact_ParticipantId");

                entity.Property(e => e.AddressPostcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddressState)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddressStreet)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressSuburb)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyResponseAccessInformation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClEmergencyContacts)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_EmergencyContact_CL_Participant");
            });

            modelBuilder.Entity<ClHouseholdDetail>(entity =>
            {
                entity.HasKey(e => e.HouseholdDetailsId);

                entity.ToTable("CL_HouseholdDetails");

                entity.HasIndex(e => e.ParticipantId, "CL_HouseholdDetails_ParticipantId");

                entity.Property(e => e.EquipmentDetails)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OtherPets)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pets)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClHouseholdDetails)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_HouseholdDetails_CL_Participant");
            });

            modelBuilder.Entity<ClInterest>(entity =>
            {
                entity.HasKey(e => e.InterestsId);

                entity.ToTable("CL_Interests");

                entity.Property(e => e.InterestsDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClJobService>(entity =>
            {
                entity.HasKey(e => e.JobServiceId);

                entity.ToTable("CL_JobService");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClOtherContact>(entity =>
            {
                entity.HasKey(e => e.OtherContactId);

                entity.ToTable("CL_OtherContact");

                entity.HasIndex(e => e.ParticipantId, "CL_OtherContact_ParticipantId");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClOtherContacts)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_OtherContact_CL_Participant");
            });

            modelBuilder.Entity<ClParticipant>(entity =>
            {
                entity.HasKey(e => e.ParticpantId);

                entity.ToTable("CL_Participant");

                entity.HasIndex(e => e.AccountHolderId, "CL_Participant_AccountHolderId");

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GenderOther)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountHolder)
                    .WithMany(p => p.ClParticipants)
                    .HasForeignKey(d => d.AccountHolderId)
                    .HasConstraintName("FK_CL_Participant_CL_AccountHolder");
            });

            modelBuilder.Entity<ClParticipantCulturalBackground>(entity =>
            {
                entity.HasKey(e => e.ParticipantCulturalBackgroundId);

                entity.ToTable("CL_ParticipantCulturalBackground");

                entity.HasIndex(e => e.CulturalBackgroundId, "CL_ParticipantCulturalBackground_CulturalBackgroundId");

                entity.HasIndex(e => e.ParticipantId, "CL_ParticipantCulturalBackground_ParticipantId");

                entity.HasOne(d => d.CulturalBackground)
                    .WithMany(p => p.ClParticipantCulturalBackgrounds)
                    .HasForeignKey(d => d.CulturalBackgroundId)
                    .HasConstraintName("FK_CL_ParticipantCulturalBackground_CulturalBackground");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClParticipantCulturalBackgrounds)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_ParticipantCulturalBackground_CL_Participant");
            });

            modelBuilder.Entity<ClParticipantInterest>(entity =>
            {
                entity.HasKey(e => e.ParticipantInterestsId);

                entity.ToTable("CL_ParticipantInterests");

                entity.HasIndex(e => e.InterestsId, "CL_ParticipantInterests_InterestsId");

                entity.HasIndex(e => e.ParticipantId, "CL_ParticipantInterests_ParticipantId");

                entity.HasOne(d => d.Interests)
                    .WithMany(p => p.ClParticipantInterests)
                    .HasForeignKey(d => d.InterestsId)
                    .HasConstraintName("FK_CL_ParticipantInterests_CL_Interests");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClParticipantInterests)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_ParticipantInterests_CL_Participant");
            });

            modelBuilder.Entity<ClParticipantInterestsOther>(entity =>
            {
                entity.HasKey(e => e.ParticipantInterestsOtherId);

                entity.ToTable("CL_ParticipantInterestsOther");

                entity.Property(e => e.InterestDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClParticipantLanguage>(entity =>
            {
                entity.HasKey(e => e.ParticipantLanguageId);

                entity.ToTable("CL_ParticipantLanguage");

                entity.HasIndex(e => e.LanguageId, "CL_ParticipantLanguage_LanguageId");

                entity.HasIndex(e => e.ParticipantId, "CL_ParticipantLanguage_ParticipantId");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ClParticipantLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_CL_ParticipantLanguage_Language");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClParticipantLanguages)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_ParticipantLanguage_CL_Participant");
            });

            modelBuilder.Entity<ClParticipantMedication>(entity =>
            {
                entity.HasKey(e => e.ParticipantMedicationId);

                entity.ToTable("CL_ParticipantMedication");

                entity.HasIndex(e => e.ParticipantId, "CL_ParticipantMedication_ParticipantId");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Dosage)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Medication)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonTaken)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClParticipantMedications)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_ParticipantMedication_CL_Participant");
            });

            modelBuilder.Entity<ClParticipantMedicationInformation>(entity =>
            {
                entity.HasKey(e => e.ParticipantMedicationInformationId);

                entity.ToTable("CL_ParticipantMedicationInformation");

                entity.HasIndex(e => e.ParticipantId, "CL_ParticipantMedicationInformation_ParticipantId");

                entity.Property(e => e.CarePlan)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Gpdocuments)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("GPDocuments");

                entity.Property(e => e.OtherDocuments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SupportWorkerInstructions).IsUnicode(false);

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClParticipantMedicationInformations)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_ParticipantMedicationInformation_CL_Participant");
            });

            modelBuilder.Entity<ClParticipantNeed>(entity =>
            {
                entity.HasKey(e => e.ParticipantNeedsId);

                entity.ToTable("CL_ParticipantNeeds");

                entity.HasIndex(e => e.ParticipantId, "CL_ParticipantNeeds_ParticipantId");

                entity.HasIndex(e => e.ParticipantNeedsAreaId, "CL_ParticipantNeeds_ParticipantNeedsAreaId");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClParticipantNeeds)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_ParticipantNeeds_CL_Participant");

                entity.HasOne(d => d.ParticipantNeedsArea)
                    .WithMany(p => p.ClParticipantNeeds)
                    .HasForeignKey(d => d.ParticipantNeedsAreaId)
                    .HasConstraintName("FK_CL_ParticipantNeeds_CL_ParticipantNeedsArea");
            });

            modelBuilder.Entity<ClParticipantNeedsArea>(entity =>
            {
                entity.HasKey(e => e.ParticipantNeedsAreaId);

                entity.ToTable("CL_ParticipantNeedsArea");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClParticipantReligion>(entity =>
            {
                entity.HasKey(e => e.ParticipantReligionId);

                entity.ToTable("CL_ParticipantReligion");

                entity.HasIndex(e => e.ParticipantId, "CL_ParticipantReligion_ParticipantId");

                entity.HasIndex(e => e.ReligionId, "CL_ParticipantReligion_ReligionId");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClParticipantReligions)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_ParticipantReligion_CL_Participant");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.ClParticipantReligions)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_CL_ParticipantReligion_Religion");
            });

            modelBuilder.Entity<ClPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.PaymentDetailsId);

                entity.ToTable("CL_PaymentDetails");

                entity.HasIndex(e => e.ParticipantId, "CL_PaymentDetails_ParticipantId");

                entity.Property(e => e.BankAccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bsb).HasColumnName("BSB");

                entity.Property(e => e.Cccvv).HasColumnName("CCCVV");

                entity.Property(e => e.CcexpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CCExpiryDate");

                entity.Property(e => e.Ccname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CCName");

                entity.Property(e => e.Ccnumber).HasColumnName("CCNumber");

                entity.Property(e => e.DirectDebitAuthorisationForm)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FundingType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FundingTypeOther)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeCarePackageProviderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherFundingDocument1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherFundingDocument2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherFundingDocument3)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlanType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClPaymentDetails)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_PaymentDetails_CL_Participant");
            });

            modelBuilder.Entity<ClSocialNeedsGoal>(entity =>
            {
                entity.HasKey(e => e.SocialNeedsGoalsId);

                entity.ToTable("CL_SocialNeedsGoals");

                entity.HasIndex(e => e.ParticipantId, "CL_SocialNeedsGoals_ParticipantId");

                entity.Property(e => e.SocialNeedsDescription).IsUnicode(false);

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ClSocialNeedsGoals)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_CL_SocialNeedsGoals_CL_Participant");
            });

            modelBuilder.Entity<ClloginAudit>(entity =>
            {
                entity.ToTable("CLLoginAudit");

                entity.HasIndex(e => e.ClientId, "CLLoginAudit_ClientId");

                entity.Property(e => e.ClloginAuditId).HasColumnName("CLLoginAuditId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClloginAudits)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_CLLoginAudit_SW_Client");
            });

            modelBuilder.Entity<CulturalBackground>(entity =>
            {
                entity.ToTable("CulturalBackground");

                entity.Property(e => e.CulturalBackground1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CulturalBackground");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job");

                entity.HasIndex(e => e.ParticipantId, "Job_ParticipantId");

                entity.Property(e => e.GenderPreference)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hours)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobDetails).IsUnicode(false);

                entity.Property(e => e.ParticipantDescription).IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SupportWorkDescription).IsUnicode(false);

                entity.Property(e => e.TypeOfJob)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.ParticipantId)
                    .HasConstraintName("FK_Job_CL_Participant");
            });

            modelBuilder.Entity<JobAssignment>(entity =>
            {
                entity.ToTable("JobAssignment");

                entity.HasIndex(e => e.JobId, "JobAssignment_JobId");

                entity.HasIndex(e => e.SupportWorkerId, "JobAssignment_SupportWorkerId");

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobAssignments)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_JobAssignment_Job");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.JobAssignments)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_JobAssignment_SW_SupportWorker");
            });

            modelBuilder.Entity<JobMessageLog>(entity =>
            {
                entity.ToTable("JobMessageLog");

                entity.HasIndex(e => e.JobAssignmentId, "JobMessageLog_JobAssignmentId");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MessageDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.JobAssignment)
                    .WithMany(p => p.JobMessageLogs)
                    .HasForeignKey(d => d.JobAssignmentId)
                    .HasConstraintName("FK_JobMessageLog_JobAssignment");
            });

            modelBuilder.Entity<JobTime>(entity =>
            {
                entity.HasKey(e => e.JobTimesId);

                entity.HasIndex(e => e.JobId, "JobTimes_JobId");

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOfDay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobTimes)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_JobTimes_Job");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.Property(e => e.Language1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Language");
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.ToTable("Religion");

                entity.Property(e => e.Religion1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Religion");
            });

            modelBuilder.Entity<ScSupportCoordinator>(entity =>
            {
                entity.HasKey(e => e.SupportCoordinatorId);

                entity.ToTable("SC_SupportCoordinator");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScSupportCoordinatorProfile>(entity =>
            {
                entity.HasKey(e => e.SupportCoordinatorProfileId);

                entity.ToTable("SC_SupportCoordinatorProfile");

                entity.HasIndex(e => e.SupportCoordinatorId, "SC_SupportCoordinatorProfile_SupportCoordinatorId");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupportCoordinator)
                    .WithMany(p => p.ScSupportCoordinatorProfiles)
                    .HasForeignKey(d => d.SupportCoordinatorId)
                    .HasConstraintName("FK_SC_SupportCoordinatorProfile_SC_SupportCoordinator");
            });

            modelBuilder.Entity<ScSupportCoordinatorSupportWorker>(entity =>
            {
                entity.HasKey(e => e.UpportCoordinatorSupportWorkerId);

                entity.ToTable("SC_SupportCoordinatorSupportWorker");

                entity.HasIndex(e => e.SupportCoordinatorId, "SC_SupportCoordinatorSupportWorker_SupportCoordinatorId");

                entity.Property(e => e.UpportCoordinatorSupportWorkerId).HasColumnName("upportCoordinatorSupportWorkerId");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupportCoordinator)
                    .WithMany(p => p.ScSupportCoordinatorSupportWorkers)
                    .HasForeignKey(d => d.SupportCoordinatorId)
                    .HasConstraintName("FK_SC_SupportCoordinatorSupportWorker_SC_SupportCoordinator");
            });

            modelBuilder.Entity<ScimpersonisationLoginAudit>(entity =>
            {
                entity.HasKey(e => e.ScimpLoginAuditId);

                entity.ToTable("SCImpersonisationLoginAudit");

                entity.HasIndex(e => e.SupportCoordinatorId, "SCImpersonisationLoginAudit_SupportCoordinatorId");

                entity.Property(e => e.ScimpLoginAuditId).HasColumnName("SCImpLoginAuditId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.SupportCoordinator)
                    .WithMany(p => p.ScimpersonisationLoginAudits)
                    .HasForeignKey(d => d.SupportCoordinatorId)
                    .HasConstraintName("FK_SCImpersonisationLoginAudit_SC_SupportCoordinator");
            });

            modelBuilder.Entity<ScloginAudit>(entity =>
            {
                entity.ToTable("SCLoginAudit");

                entity.HasIndex(e => e.SupportCoordinatorId, "SCLoginAudit_SupportCoordinatorId");

                entity.Property(e => e.ScloginAuditId).HasColumnName("SCLoginAuditId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.SupportCoordinator)
                    .WithMany(p => p.ScloginAudits)
                    .HasForeignKey(d => d.SupportCoordinatorId)
                    .HasConstraintName("FK_SCLoginAudit_SC_SupportCoordinator");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Status1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Status");
            });

            modelBuilder.Entity<SwAvailability>(entity =>
            {
                entity.HasKey(e => e.AvailabilityId);

                entity.ToTable("SW_Availability");

                entity.HasIndex(e => e.SupportWorkerId, "SW_Availability_SupportWorkerId");

                entity.Property(e => e.BasePostcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phrate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PHRate");

                entity.Property(e => e.SaturdayRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SundayRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weekday12HrRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weekday24HrRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeekdayRateEarly).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeekdayRateLate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwAvailabilities)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_Availability_SW_SupportWorker");
            });

            modelBuilder.Entity<SwAvailabilityDetail>(entity =>
            {
                entity.HasKey(e => e.AvailabilityDetailsId);

                entity.ToTable("SW_AvailabilityDetails");

                entity.HasIndex(e => e.SupportWorkerId, "SW_AvailabilityDetails_SupportWorkerId");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwAvailabilityDetails)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_AvailabilityDetails_SW_SupportWorker");
            });

            modelBuilder.Entity<SwClient>(entity =>
            {
                entity.HasKey(e => e.ClientId);

                entity.ToTable("SW_Client");

                entity.HasIndex(e => e.SupportWorkerId, "SW_Client_SupportWorkerId");

                entity.Property(e => e.DateAdded)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwClients)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SW_Client_SW_SupportWorker");
            });

            modelBuilder.Entity<SwCoreExperience>(entity =>
            {
                entity.HasKey(e => e.CoreExperienceId);

                entity.ToTable("SW_CoreExperience");

                entity.HasIndex(e => e.CoreExperienceFieldId, "SW_CoreExperience_CoreExperienceFieldId");

                entity.Property(e => e.CoreExperienceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CoreExperienceField)
                    .WithMany(p => p.SwCoreExperiences)
                    .HasForeignKey(d => d.CoreExperienceFieldId)
                    .HasConstraintName("FK_SW_CoreExperience_SW_CoreExperience");
            });

            modelBuilder.Entity<SwCoreExperienceField>(entity =>
            {
                entity.HasKey(e => e.CoreExperienceFieldId);

                entity.ToTable("SW_CoreExperienceField");

                entity.Property(e => e.CoreExperienceFieldName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SwEducation>(entity =>
            {
                entity.HasKey(e => e.EducationId);

                entity.ToTable("SW_Education");

                entity.HasIndex(e => e.SupportWorkerId, "SW_Education_SupportWorkerId");

                entity.Property(e => e.DegreeCourse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Institution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwEducations)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_Education_SW_SupportWorker");
            });

            modelBuilder.Entity<SwEmailPreference>(entity =>
            {
                entity.HasKey(e => e.EmailPreferencesId);

                entity.ToTable("SW_EmailPreferences");

                entity.HasIndex(e => e.SupportWorkerId, "SW_EmailPreferences_SupportWorkerId");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwEmailPreferences)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_EmailPreferences_SW_SupportWorker");
            });


            modelBuilder.Entity<CLEmailPreference>(entity =>
            {
                entity.HasKey(e => e.CLEmailPreferencesId);

                entity.ToTable("CL_EmailPreference");

                entity.HasIndex(e => e.AccountHolderId, "CL_EmailPreference_AccountHolderId");

                entity.HasOne(d => d.ClAccountHolder)
                    .WithMany(p => p.ClEmailPreference)
                    .HasForeignKey(d => d.AccountHolderId)
                    .HasConstraintName("FK_CL_EmailPreference_CL_AccountHolder");
            });

            modelBuilder.Entity<SwEmergencyContact>(entity =>
            {
                entity.ToTable("SW_EmergencyContact");

                entity.HasIndex(e => e.SupportWorkerId, "SW_EmergencyContact_SupportWorkerId");

                entity.Property(e => e.SwemergencyContactId).HasColumnName("SWEmergencyContactId");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwEmergencyContacts)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_EmergencyContact_SW_SupportWorker");
            });

            modelBuilder.Entity<SwInsuranceDeclaration>(entity =>
            {
                entity.HasKey(e => e.InsuranceDeclarationId);

                entity.ToTable("SW_InsuranceDeclaration");

                entity.HasIndex(e => e.SupportWorkerId, "SW_InsuranceDeclaration_SupportWorkerId");

                entity.Property(e => e.BankruptcyDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfFirstExperience).HasColumnType("datetime");

                entity.Property(e => e.FraudDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwInsuranceDeclarations)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_InsuranceDeclaration_SW_SupportWorker");
            });

            modelBuilder.Entity<SwInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("SW_Invoice");

                entity.HasIndex(e => e.InvoiceTemplateId, "SW_Invoice_InvoiceTemplateId");

                entity.HasIndex(e => e.TimesheetId, "SW_Invoice_TimesheetId");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.InvoiceTemplate)
                    .WithMany(p => p.SwInvoices)
                    .HasForeignKey(d => d.InvoiceTemplateId)
                    .HasConstraintName("FK_SW_Invoice_SW_InvoiceTemplate");

                entity.HasOne(d => d.Timesheet)
                    .WithMany(p => p.SwInvoices)
                    .HasForeignKey(d => d.TimesheetId)
                    .HasConstraintName("FK_SW_Invoice_SW_Timesheet");
            });

            modelBuilder.Entity<SwInvoiceTemplate>(entity =>
            {
                entity.HasKey(e => e.InvoiceTemplateId);

                entity.ToTable("SW_InvoiceTemplate");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SwMandatoryCheck>(entity =>
            {
                entity.HasKey(e => e.MandatoryCheckId);

                entity.ToTable("SW_MandatoryCheck");

                entity.HasIndex(e => e.SupportWorkerId, "SW_MandatoryCheck_SupportWorkerId");

                entity.Property(e => e.Covid19training).HasColumnName("COVID19Training");

                entity.Property(e => e.Covid19trainingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("COVID19TrainingDate");

                entity.Property(e => e.Covid19trainingDoc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COVID19TrainingDoc");

                entity.Property(e => e.OsresCitizen).HasColumnName("OSResCitizen");

                entity.Property(e => e.OsresCitizenStatDec)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("OSResCitizenStatDec");

                entity.Property(e => e.PoliceCheckDate).HasColumnType("datetime");

                entity.Property(e => e.PoliceCheckDoc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PoliceCheckExpiry).HasColumnType("datetime");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwMandatoryChecks)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_MandatoryCheck_SW_SupportWorker");
            });

            modelBuilder.Entity<SwQualification>(entity =>
            {
                entity.HasKey(e => e.QualificationId);

                entity.ToTable("SW_Qualification");

                entity.HasIndex(e => e.ServiceId, "SW_Qualification_ServiceId");

                entity.Property(e => e.Ahrparequired).HasColumnName("AHRPARequired");

                entity.Property(e => e.BoardRequirementsName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.SwQualifications)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_SW_Qualification_SW_Service");
            });

            modelBuilder.Entity<SwReference>(entity =>
            {
                entity.HasKey(e => e.ReferenceId);

                entity.ToTable("SW_Reference");

                entity.HasIndex(e => e.SupportWorkerId, "SW_Reference_SupportWorkerId");

                entity.Property(e => e.BusinessOrEmployer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Certificate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobtitleOrRole)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwReferences)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_Reference_SW_SupportWorker");
            });

            modelBuilder.Entity<SwService>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("SW_Service");

                entity.HasIndex(e => e.ServiceGroupId, "SW_Service_ServiceGroupId");

                entity.Property(e => e.Service)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ServiceGroup)
                    .WithMany(p => p.SwServices)
                    .HasForeignKey(d => d.ServiceGroupId)
                    .HasConstraintName("FK_SW_Service_SW_ServiceGroup");
            });

            modelBuilder.Entity<SwServiceGroup>(entity =>
            {
                entity.HasKey(e => e.ServiceGroupId);

                entity.ToTable("SW_ServiceGroup");

                entity.Property(e => e.ServiceGroup)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SwSupportWorker>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerId);

                entity.ToTable("SW_SupportWorker");

                entity.HasIndex(e => e.StatusId, "SW_SupportWorker_StatusId");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.SwSupportWorkers)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_SW_SupportWorker_Status");
            });

            modelBuilder.Entity<SwSupportWorkerAdditionalTraining>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerAdditionalTrainingId);

                entity.ToTable("SW_SupportWorkerAdditionalTraining");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerAdditionalTraining_SupportWorkerId");

                entity.Property(e => e.Covidicc).HasColumnName("COVIDICC");

                entity.Property(e => e.CovidiccacquiredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("COVIDICCAcquiredDate");

                entity.Property(e => e.CovidiccexpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("COVIDICCExpiryDate");

                entity.Property(e => e.Covidiccupload)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COVIDICCUpload");

                entity.Property(e => e.CpracquiredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CPRAcquiredDate");

                entity.Property(e => e.Cprcertificate).HasColumnName("CPRCertificate");

                entity.Property(e => e.CprexpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CPRExpiryDate");

                entity.Property(e => e.Cprupload)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CPRUpload");

                entity.Property(e => e.FirstAidAcquiredDate).HasColumnType("datetime");

                entity.Property(e => e.FirstAidExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FirstAidUpload)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NdiswomacquiredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NDISWOMAcquiredDate");

                entity.Property(e => e.Ndiswomcertificate).HasColumnName("NDISWOMCertificate");

                entity.Property(e => e.NdiswomexpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NDISWOMExpiryDate");

                entity.Property(e => e.Ndiswomupload)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NDISWOMUpload");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerAdditionalTrainings)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerAdditionalTraining_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerAhdetail>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerAhdetailsId);

                entity.ToTable("SW_SupportWorkerAHDetails");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerAHDetails_SupportWorkerId");

                entity.Property(e => e.SupportWorkerAhdetailsId).HasColumnName("SupportWorkerAHDetailsId");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerAhdetails)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerAHDetails_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerBankAccount>(entity =>
            {
                entity.HasKey(e => e.BankAccountId);

                entity.ToTable("SW_SupportWorkerBankAccount");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerBankAccount_SupportWorkerId");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bsb).HasColumnName("BSB");

                entity.Property(e => e.Dlnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DLNumber");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerBankAccounts)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerBankAccount_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerCoreExperience>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerCoreExperienceId);

                entity.ToTable("SW_SupportWorkerCoreExperience");

                entity.HasIndex(e => e.CoreExperienceId, "SW_SupportWorkerCoreExperience_CoreExperienceId");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerCoreExperience_SupportWorkerId");

                entity.HasOne(d => d.CoreExperience)
                    .WithMany(p => p.SwSupportWorkerCoreExperiences)
                    .HasForeignKey(d => d.CoreExperienceId)
                    .HasConstraintName("FK_SW_SupportWorkerCoreExperience_SW_CoreExperience");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerCoreExperiences)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerCoreExperience_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerCulturalBackground>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerCulturalBackgroundId);

                entity.ToTable("SW_SupportWorkerCulturalBackground");

                entity.HasIndex(e => e.CulturalBackgroundId, "SW_SupportWorkerCulturalBackground_CulturalBackgroundId");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerCulturalBackground_SupportWorkerId");

                entity.HasOne(d => d.CulturalBackground)
                    .WithMany(p => p.SwSupportWorkerCulturalBackgrounds)
                    .HasForeignKey(d => d.CulturalBackgroundId)
                    .HasConstraintName("FK_SW_SupportWorkerCulturalBackground_CulturalBackground");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerCulturalBackgrounds)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerCulturalBackground_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerLanguage>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerLanguageId);

                entity.ToTable("SW_SupportWorkerLanguage");

                entity.HasIndex(e => e.LanguageId, "SW_SupportWorkerLanguage_LanguageId");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerLanguage_SupportWorkerId");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SwSupportWorkerLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_SW_SupportWorkerLanguage_Language");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerLanguages)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerLanguage_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerOtherQualification>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerOtherQualificationId);

                entity.ToTable("SW_SupportWorkerOtherQualification");

                entity.HasIndex(e => e.ServiceGroupId, "SW_SupportWorkerOtherQualification_ServiceGroupId");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerOtherQualification_SupportWorkerId");

                entity.Property(e => e.Certificate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherQualification)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ServiceGroup)
                    .WithMany(p => p.SwSupportWorkerOtherQualifications)
                    .HasForeignKey(d => d.ServiceGroupId)
                    .HasConstraintName("FK_SW_SupportWorkerOtherQualification_SW_ServiceGroup");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerOtherQualifications)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerOtherQualification_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerOtherTraining>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerOtherTrainingId);

                entity.ToTable("SW_SupportWorkerOtherTraining");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerOtherTraining_SupportWorkerId");

                entity.Property(e => e.Certificate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherQualification)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerOtherTrainings)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerOtherTraining_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerPcdetail>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerPcdetailsId);

                entity.ToTable("SW_SupportWorkerPCDetails");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerPCDetails_SupportWorkerId");

                entity.Property(e => e.SupportWorkerPcdetailsId).HasColumnName("SupportWorkerPCDetailsId");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerPcdetails)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerPCDetails_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerPresign>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerPresignId);

                entity.ToTable("SW_SupportWorkerPresign");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerPresign_SupportWorkerId");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HowHear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkHours)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerPresigns)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerPresign_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerProfile>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerProfileId);

                entity.ToTable("SW_SupportWorkerProfile");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerProfile_SupportWorkerId");

                entity.Property(e => e.Bio).IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPartnershipDetails).IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FriendlyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartnershipName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerProfiles)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerProfile_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerQualification>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerQualificationId);

                entity.ToTable("SW_SupportWorkerQualification");

                entity.HasIndex(e => e.QualificationId, "SW_SupportWorkerQualification_QualificationId");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerQualification_SupportWorkerId");

                entity.Property(e => e.AcquiredDate).HasColumnType("datetime");

                entity.Property(e => e.Certificate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComplaintDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.SwSupportWorkerQualifications)
                    .HasForeignKey(d => d.QualificationId)
                    .HasConstraintName("FK_SW_SupportWorkerQualification_SW_Qualification");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerQualifications)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerQualification_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerReligion>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerReligionId);

                entity.ToTable("SW_SupportWorkerReligion");

                entity.HasIndex(e => e.ReligionId, "SW_SupportWorkerReligion_ReligionId");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerReligion_SupportWorkerId");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.SwSupportWorkerReligions)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_SW_SupportWorkerReligion_Religion");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerReligions)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerReligion_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerRndetail>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerRndetailsId);

                entity.ToTable("SW_SupportWorkerRNDetails");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerRNDetails_SupportWorkerId");

                entity.Property(e => e.SupportWorkerRndetailsId).HasColumnName("SupportWorkerRNDetailsId");

                entity.Property(e => e.AhpraregistrationActiveConfirm).HasColumnName("AHPRARegistrationActiveConfirm");

                entity.Property(e => e.ComplaintDetails).IsUnicode(false);

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerRndetails)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerRNDetails_SW_SupportWorker");
            });

            modelBuilder.Entity<SwSupportWorkerService>(entity =>
            {
                entity.HasKey(e => e.SupportWorkerServiceId);

                entity.ToTable("SW_SupportWorkerService");

                entity.HasIndex(e => e.ServiceId, "SW_SupportWorkerService_ServiceId");

                entity.HasIndex(e => e.SupportWorkerId, "SW_SupportWorkerService_SupportWorkerId");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.SwSupportWorkerServices)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_SW_SupportWorkerService_SW_Service");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwSupportWorkerServices)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_SupportWorkerService_SW_SupportWorker");
            });

            modelBuilder.Entity<SwTimesheet>(entity =>
            {
                entity.HasKey(e => e.TimesheetId);

                entity.ToTable("SW_Timesheet");

                entity.HasIndex(e => e.SupportWorkerId, "SW_Timesheet_SupportWorkerId");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentReceived).HasColumnType("datetime");

                entity.Property(e => e.Rate).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.ShiftNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwTimesheets)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_Timesheet_SW_SupportWorker");
            });

            modelBuilder.Entity<SwTimesheetIncident>(entity =>
            {
                entity.HasKey(e => e.IncidentId);

                entity.ToTable("SW_TimesheetIncident");

                entity.HasIndex(e => e.TimesheetId, "SW_TimesheetIncident_TimesheetId");

                entity.Property(e => e.IncidentDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Timesheet)
                    .WithMany(p => p.SwTimesheetIncidents)
                    .HasForeignKey(d => d.TimesheetId)
                    .HasConstraintName("FK_SW_TimesheetIncident_SW_Timesheet");
            });

            modelBuilder.Entity<SwTimesheetStatus>(entity =>
            {
                entity.HasKey(e => e.TimesheetStatusId);

                entity.ToTable("SW_TimesheetStatus");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SwTransportInfo>(entity =>
            {
                entity.HasKey(e => e.TransportInfoId);

                entity.ToTable("SW_TransportInfo");

                entity.HasIndex(e => e.SupportWorkerId, "SW_TransportInfo_SupportWorkerId");

                entity.Property(e => e.DlexpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DLExpiryDate");

                entity.Property(e => e.Dlnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DLNumber");

                entity.Property(e => e.Dlstate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DLState");

                entity.Property(e => e.Dlupload)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DLUpload");

                entity.Property(e => e.MvinsuranceType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MVInsuranceType");

                entity.Property(e => e.MvlicencePlate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MVLicencePlate");

                entity.Property(e => e.MvregistrationExpiry)
                    .HasColumnType("datetime")
                    .HasColumnName("MVRegistrationExpiry");

                entity.Property(e => e.MvregistrationUpload)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MVRegistrationUpload");

                entity.Property(e => e.Mvtype)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MVType");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwTransportInfos)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_TransportInfo_SW_SupportWorker");
            });

            modelBuilder.Entity<SwWorkHistory>(entity =>
            {
                entity.HasKey(e => e.WorkHistoryId);

                entity.ToTable("SW_WorkHistory");

                entity.HasIndex(e => e.SupportWorkerId, "SW_WorkHistory_SupportWorkerId");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwWorkHistories)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SW_WorkHistory_SW_SupportWorker");
            });

            modelBuilder.Entity<SwloginAudit>(entity =>
            {
                entity.ToTable("SWLoginAudit");

                entity.HasIndex(e => e.SupportWorkerId, "SWLoginAudit_SupportWorkerId");

                entity.Property(e => e.SwloginAuditId).HasColumnName("SWLoginAuditId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.SupportWorker)
                    .WithMany(p => p.SwloginAudits)
                    .HasForeignKey(d => d.SupportWorkerId)
                    .HasConstraintName("FK_SWLoginAudit_SW_SupportWorker");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
