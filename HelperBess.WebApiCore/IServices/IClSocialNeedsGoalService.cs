using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClSocialNeedsGoalService
    {
        IEnumerable<ClSocialNeedsGoal> GetClSocialNeedsGoal();
        ClSocialNeedsGoal GetClSocialNeedsGoalById(int id);
        IEnumerable<ClSocialNeedsGoal> GetClSocialNeedsGoalByParticipantId(int participantid);
        ClSocialNeedsGoal AddClSocialNeedsGoal(ClSocialNeedsGoal ClSocialNeedsGoal);
        ClSocialNeedsGoal UpdateClSocialNeedsGoal(ClSocialNeedsGoal ClSocialNeedsGoal);
        ClSocialNeedsGoal DeleteClSocialNeedsGoal(int id);
    }
}
