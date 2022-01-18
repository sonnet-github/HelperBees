using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwCoreExperienceService
    {
        IEnumerable<SwCoreExperience> GetSwCoreExperience();
        SwCoreExperience GetSwCoreExperienceById(int id);
        SwCoreExperience AddSwCoreExperience(SwCoreExperience SwCoreExperience);
        SwCoreExperience UpdateSwCoreExperience(SwCoreExperience SwCoreExperience);
        SwCoreExperience DeleteSwCoreExperience(int id);
    }
}
