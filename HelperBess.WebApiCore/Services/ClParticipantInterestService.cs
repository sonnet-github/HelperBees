using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClParticipantInterestService :IClParticipantInterestService
    {
        HelperBeesContext dbContext;
        public ClParticipantInterestService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClParticipantInterest AddClParticipantInterest(ClParticipantInterest ClParticipantInterest)
        {
            if (ClParticipantInterest != null)
            {
                dbContext.ClParticipantInterests.Add(ClParticipantInterest);
                dbContext.SaveChanges();
                return ClParticipantInterest;
            }
            return null;
        }

        public ClParticipantInterest DeleteClParticipantInterest(int id)
        {
            var ClParticipantInterests = dbContext.ClParticipantInterests.FirstOrDefault(x => x.ParticipantInterestsId == id);
            dbContext.Entry(ClParticipantInterests).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClParticipantInterests;
        }

        public IEnumerable<ClParticipantInterest> GetClParticipantInterest()
        {
            var ClParticipantInterests = dbContext.ClParticipantInterests.ToList();
            return ClParticipantInterests;
        }

        public ClParticipantInterest GetClParticipantInterestById(int id)
        {
            var ClParticipantInterests = dbContext.ClParticipantInterests.FirstOrDefault(x => x.ParticipantInterestsId == id);
            return ClParticipantInterests;
        }

        public ClParticipantInterest UpdateClParticipantInterest(ClParticipantInterest ClParticipantInterests)
        {
            dbContext.Entry(ClParticipantInterests).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClParticipantInterests;
        }
    }
}
