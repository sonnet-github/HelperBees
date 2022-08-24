using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClParticipantInterestsOtherService : IClParticipantInterestsOtherService
    {
        HelperBeesContext dbContext;
        public ClParticipantInterestsOtherService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClParticipantInterestsOther AddClParticipantInterestsOther(ClParticipantInterestsOther ClParticipantInterestsOther)
        {
            if (ClParticipantInterestsOther != null)
            {
                dbContext.ClParticipantInterestsOthers.Add(ClParticipantInterestsOther);
                dbContext.SaveChanges();
                return ClParticipantInterestsOther;
            }
            return null;
        }

        public ClParticipantInterestsOther DeleteClParticipantInterestsOther(int id)
        {
            var ClParticipantInterestsOthers = dbContext.ClParticipantInterestsOthers.FirstOrDefault(x => x.ParticipantInterestsOtherId == id);
            dbContext.Entry(ClParticipantInterestsOthers).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClParticipantInterestsOthers;
        }

        public IEnumerable<ClParticipantInterestsOther> GetClParticipantInterestsOther()
        {
            var ClParticipantInterestsOthers = dbContext.ClParticipantInterestsOthers.ToList();
            return ClParticipantInterestsOthers;
        }

        public ClParticipantInterestsOther GetClParticipantInterestsOtherById(int id)
        {
            var ClParticipantInterestsOthers = dbContext.ClParticipantInterestsOthers.FirstOrDefault(x => x.ParticipantInterestsOtherId == id);
            return ClParticipantInterestsOthers;
        }

        public IEnumerable<ClParticipantInterestsOther> GetClParticipantInterestsOtherByParticipantId(int participantid)
        {
            var ClParticipantInterestsOthers = dbContext.ClParticipantInterestsOthers.Where(x => x.ParticipantId == participantid);
            return ClParticipantInterestsOthers;
        }

        public ClParticipantInterestsOther UpdateClParticipantInterestsOther(ClParticipantInterestsOther ClParticipantInterestsOthers)
        {
            dbContext.Entry(ClParticipantInterestsOthers).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClParticipantInterestsOthers;
        }
    }
}
