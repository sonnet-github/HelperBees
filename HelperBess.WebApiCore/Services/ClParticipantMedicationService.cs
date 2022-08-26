using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClParticipantMedicationService : IClParticipantMedicationService
    {
        HelperBeesContext dbContext;
        public ClParticipantMedicationService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClParticipantMedication AddClParticipantMedication(ClParticipantMedication ClParticipantMedication)
        {
            if (ClParticipantMedication != null)
            {
                dbContext.ClParticipantMedications.Add(ClParticipantMedication);
                dbContext.SaveChanges();
                return ClParticipantMedication;
            }
            return null;
        }

        public ClParticipantMedication DeleteClParticipantMedication(int id)
        {
            var ClParticipantMedications = dbContext.ClParticipantMedications.FirstOrDefault(x => x.ParticipantMedicationId == id);
            dbContext.Entry(ClParticipantMedications).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClParticipantMedications;
        }

        public IEnumerable<ClParticipantMedication> GetClParticipantMedication()
        {
            var ClParticipantMedications = dbContext.ClParticipantMedications.ToList();
            return ClParticipantMedications;
        }

        public ClParticipantMedication GetClParticipantMedicationById(int id)
        {
            var ClParticipantMedications = dbContext.ClParticipantMedications.FirstOrDefault(x => x.ParticipantMedicationId == id);
            return ClParticipantMedications;
        }

        public IEnumerable<ClParticipantMedication> GetClParticipantMedicationByParticipantId(int participantid)
        {
            var ClParticipantMedications = dbContext.ClParticipantMedications.Where(x => x.ParticipantId == participantid);
            return ClParticipantMedications;
        }

        public ClParticipantMedication UpdateClParticipantMedication(ClParticipantMedication ClParticipantMedications)
        {
            dbContext.Entry(ClParticipantMedications).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClParticipantMedications;
        }
    }
}
