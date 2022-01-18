using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClParticipantNeedService : IClParticipantNeedService
    {
        HelperBeesContext dbContext;
        public ClParticipantNeedService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClParticipantNeed AddClParticipantNeed(ClParticipantNeed ClParticipantNeed)
        {
            if (ClParticipantNeed != null)
            {
                dbContext.ClParticipantNeeds.Add(ClParticipantNeed);
                dbContext.SaveChanges();
                return ClParticipantNeed;
            }
            return null;
        }

        public ClParticipantNeed DeleteClParticipantNeed(int id)
        {
            var ClParticipantNeeds = dbContext.ClParticipantNeeds.FirstOrDefault(x => x.ParticipantNeedsId == id);
            dbContext.Entry(ClParticipantNeeds).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClParticipantNeeds;
        }

        public IEnumerable<ClParticipantNeed> GetClParticipantNeed()
        {
            var ClParticipantNeeds = dbContext.ClParticipantNeeds.ToList();
            return ClParticipantNeeds;
        }

        public ClParticipantNeed GetClParticipantNeedById(int id)
        {
            var ClParticipantNeeds = dbContext.ClParticipantNeeds.FirstOrDefault(x => x.ParticipantNeedsId == id);
            return ClParticipantNeeds;
        }

        public ClParticipantNeed UpdateClParticipantNeed(ClParticipantNeed ClParticipantNeeds)
        {
            dbContext.Entry(ClParticipantNeeds).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClParticipantNeeds;
        }
    }
}
