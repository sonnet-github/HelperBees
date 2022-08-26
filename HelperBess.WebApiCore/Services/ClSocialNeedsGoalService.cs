using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClSocialNeedsGoalService : IClSocialNeedsGoalService
    {
        HelperBeesContext dbContext;
        public ClSocialNeedsGoalService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClSocialNeedsGoal AddClSocialNeedsGoal(ClSocialNeedsGoal ClSocialNeedsGoal)
        {
            if (ClSocialNeedsGoal != null)
            {
                dbContext.ClSocialNeedsGoals.Add(ClSocialNeedsGoal);
                dbContext.SaveChanges();
                return ClSocialNeedsGoal;
            }
            return null;
        }

        public ClSocialNeedsGoal DeleteClSocialNeedsGoal(int id)
        {
            var ClSocialNeedsGoals = dbContext.ClSocialNeedsGoals.FirstOrDefault(x => x.SocialNeedsGoalsId == id);
            dbContext.Entry(ClSocialNeedsGoals).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClSocialNeedsGoals;
        }

        public IEnumerable<ClSocialNeedsGoal> GetClSocialNeedsGoal()
        {
            var ClSocialNeedsGoals = dbContext.ClSocialNeedsGoals.ToList();
            return ClSocialNeedsGoals;
        }

        public ClSocialNeedsGoal GetClSocialNeedsGoalById(int id)
        {
            var ClSocialNeedsGoals = dbContext.ClSocialNeedsGoals.FirstOrDefault(x => x.SocialNeedsGoalsId == id);
            return ClSocialNeedsGoals;
        }

        public IEnumerable<ClSocialNeedsGoal> GetClSocialNeedsGoalByParticipantId(int participantid)
        {
            var ClSocialNeedsGoals = dbContext.ClSocialNeedsGoals.Where(x => x.ParticipantId == participantid);
            return ClSocialNeedsGoals;
        }

        public ClSocialNeedsGoal UpdateClSocialNeedsGoal(ClSocialNeedsGoal ClSocialNeedsGoals)
        {
            dbContext.Entry(ClSocialNeedsGoals).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClSocialNeedsGoals;
        }
    }
}
