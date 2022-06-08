using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClParticipantService : IClParticipantService
    {
        HelperBeesContext dbContext;
        public ClParticipantService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClParticipant AddClParticipant(ClParticipant ClParticipant)
        {
            if (ClParticipant != null)
            {
                dbContext.ClParticipants.Add(ClParticipant);
                dbContext.SaveChanges();
                return ClParticipant;
            }
            return null;
        }

        public ClParticipant DeleteClParticipant(int id)
        {
            var ClParticipants = dbContext.ClParticipants.FirstOrDefault(x => x.ParticpantId == id);
            dbContext.Entry(ClParticipants).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClParticipants;
        }

        public IEnumerable<ClParticipant> GetClParticipant()
        {
            var ClParticipants = dbContext.ClParticipants.ToList();
            return ClParticipants;
        }

        public IEnumerable<ClParticipant> GetClParticipantsByAccountHolderId(int accountHolderId)
        {
            var ClParticipants = dbContext.ClParticipants?
                                .Where(p => p.AccountHolderId == accountHolderId)?
                                .ToList();
            return ClParticipants;
        }

        public ClParticipant GetClParticipantById(int id)
        {
            var ClParticipants = dbContext.ClParticipants.FirstOrDefault(x => x.ParticpantId == id);
            return ClParticipants;
        }

        public ClParticipant UpdateClParticipant(ClParticipant ClParticipants)
        {
            dbContext.Entry(ClParticipants).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClParticipants;
        }
    }
}
