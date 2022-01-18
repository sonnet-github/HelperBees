using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClParticipantMedicationInformationService : IClParticipantMedicationInformationService
    {
        HelperBeesContext dbContext;
        public ClParticipantMedicationInformationService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClParticipantMedicationInformation AddClParticipantMedicationInformation(ClParticipantMedicationInformation ClParticipantMedicationInformation)
        {
            if (ClParticipantMedicationInformation != null)
            {
                dbContext.ClParticipantMedicationInformations.Add(ClParticipantMedicationInformation);
                dbContext.SaveChanges();
                return ClParticipantMedicationInformation;
            }
            return null;
        }

        public ClParticipantMedicationInformation DeleteClParticipantMedicationInformation(int id)
        {
            var ClParticipantMedicationInformations = dbContext.ClParticipantMedicationInformations.FirstOrDefault(x => x.ParticipantMedicationInformationId == id);
            dbContext.Entry(ClParticipantMedicationInformations).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClParticipantMedicationInformations;
        }

        public IEnumerable<ClParticipantMedicationInformation> GetClParticipantMedicationInformation()
        {
            var ClParticipantMedicationInformations = dbContext.ClParticipantMedicationInformations.ToList();
            return ClParticipantMedicationInformations;
        }

        public ClParticipantMedicationInformation GetClParticipantMedicationInformationById(int id)
        {
            var ClParticipantMedicationInformations = dbContext.ClParticipantMedicationInformations.FirstOrDefault(x => x.ParticipantMedicationInformationId == id);
            return ClParticipantMedicationInformations;
        }

        public ClParticipantMedicationInformation UpdateClParticipantMedicationInformation(ClParticipantMedicationInformation ClParticipantMedicationInformations)
        {
            dbContext.Entry(ClParticipantMedicationInformations).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClParticipantMedicationInformations;
        }
    }
}
