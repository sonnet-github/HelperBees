using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClParticipantCulturalBackgroundService : IClParticipantCulturalBackgroundService
    {
        HelperBeesContext dbContext;
        public ClParticipantCulturalBackgroundService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClParticipantCulturalBackground AddClParticipantCulturalBackground(ClParticipantCulturalBackground ClParticipantCulturalBackground)
        {
            if (ClParticipantCulturalBackground != null)
            {
                dbContext.ClParticipantCulturalBackgrounds.Add(ClParticipantCulturalBackground);
                dbContext.SaveChanges();
                return ClParticipantCulturalBackground;
            }
            return null;
        }

        public ClParticipantCulturalBackground DeleteClParticipantCulturalBackground(int id)
        {
            var ClParticipantCulturalBackgrounds = dbContext.ClParticipantCulturalBackgrounds.FirstOrDefault(x => x.ParticipantCulturalBackgroundId == id);
            dbContext.Entry(ClParticipantCulturalBackgrounds).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClParticipantCulturalBackgrounds;
        }

        public IEnumerable<ClParticipantCulturalBackground> GetClParticipantCulturalBackground()
        {
            var ClParticipantCulturalBackgrounds = dbContext.ClParticipantCulturalBackgrounds.ToList();
            return ClParticipantCulturalBackgrounds;
        }

        public ClParticipantCulturalBackground GetClParticipantCulturalBackgroundById(int id)
        {
            var ClParticipantCulturalBackgrounds = dbContext.ClParticipantCulturalBackgrounds.FirstOrDefault(x => x.ParticipantCulturalBackgroundId == id);
            return ClParticipantCulturalBackgrounds;
        }

        public IEnumerable<ClParticipantCulturalBackground> GetClParticipantCulturalBackgroundByParticipantId(int participantid)
        {
            var ClParticipantCulturalBackgrounds = dbContext.ClParticipantCulturalBackgrounds.Where(x => x.ParticipantId == participantid);
            return ClParticipantCulturalBackgrounds;
        }

        public ClParticipantCulturalBackground UpdateClParticipantCulturalBackground(ClParticipantCulturalBackground ClParticipantCulturalBackgrounds)
        {
            dbContext.Entry(ClParticipantCulturalBackgrounds).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClParticipantCulturalBackgrounds;
        }
    }
}
