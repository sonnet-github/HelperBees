using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClParticipantNeedsAreaService : IClParticipantNeedsAreaService
    {
        HelperBeesContext dbContext;
        public ClParticipantNeedsAreaService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClParticipantNeedsArea AddClParticipantNeedsArea(ClParticipantNeedsArea ClParticipantNeedsArea)
        {
            if (ClParticipantNeedsArea != null)
            {
                dbContext.ClParticipantNeedsAreas.Add(ClParticipantNeedsArea);
                dbContext.SaveChanges();
                return ClParticipantNeedsArea;
            }
            return null;
        }

        public ClParticipantNeedsArea DeleteClParticipantNeedsArea(int id)
        {
            var ClParticipantNeedsAreas = dbContext.ClParticipantNeedsAreas.FirstOrDefault(x => x.ParticipantNeedsAreaId == id);
            dbContext.Entry(ClParticipantNeedsAreas).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClParticipantNeedsAreas;
        }

        public IEnumerable<ClParticipantNeedsArea> GetClParticipantNeedsArea()
        {
            var ClParticipantNeedsAreas = dbContext.ClParticipantNeedsAreas.ToList();
            return ClParticipantNeedsAreas;
        }

        public ClParticipantNeedsArea GetClParticipantNeedsAreaById(int id)
        {
            var ClParticipantNeedsAreas = dbContext.ClParticipantNeedsAreas.FirstOrDefault(x => x.ParticipantNeedsAreaId == id);
            return ClParticipantNeedsAreas;
        }

        public ClParticipantNeedsArea UpdateClParticipantNeedsArea(ClParticipantNeedsArea ClParticipantNeedsAreas)
        {
            dbContext.Entry(ClParticipantNeedsAreas).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClParticipantNeedsAreas;
        }
    }
}
