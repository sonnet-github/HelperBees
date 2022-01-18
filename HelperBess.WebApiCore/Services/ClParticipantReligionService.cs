using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClParticipantReligionService : IClParticipantReligionService
    {
        HelperBeesContext dbContext;
        public ClParticipantReligionService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClParticipantReligion AddClParticipantReligion(ClParticipantReligion ClParticipantReligion)
        {
            if (ClParticipantReligion != null)
            {
                dbContext.ClParticipantReligions.Add(ClParticipantReligion);
                dbContext.SaveChanges();
                return ClParticipantReligion;
            }
            return null;
        }

        public ClParticipantReligion DeleteClParticipantReligion(int id)
        {
            var ClParticipantReligions = dbContext.ClParticipantReligions.FirstOrDefault(x => x.ParticipantReligionId == id);
            dbContext.Entry(ClParticipantReligions).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClParticipantReligions;
        }

        public IEnumerable<ClParticipantReligion> GetClParticipantReligion()
        {
            var ClParticipantReligions = dbContext.ClParticipantReligions.ToList();
            return ClParticipantReligions;
        }

        public ClParticipantReligion GetClParticipantReligionById(int id)
        {
            var ClParticipantReligions = dbContext.ClParticipantReligions.FirstOrDefault(x => x.ParticipantReligionId == id);
            return ClParticipantReligions;
        }

        public ClParticipantReligion UpdateClParticipantReligion(ClParticipantReligion ClParticipantReligions)
        {
            dbContext.Entry(ClParticipantReligions).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClParticipantReligions;
        }
    }
}
