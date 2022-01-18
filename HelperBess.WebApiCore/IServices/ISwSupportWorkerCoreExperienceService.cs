using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerCoreExperienceService
    {
        IEnumerable<SwSupportWorkerCoreExperience> GetSwSupportWorkerCoreExperience();
        SwSupportWorkerCoreExperience GetSwSupportWorkerCoreExperienceById(int id);
        SwSupportWorkerCoreExperience AddSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience SwSupportWorkerCoreExperience);
        SwSupportWorkerCoreExperience UpdateSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience SwSupportWorkerCoreExperience);
        SwSupportWorkerCoreExperience DeleteSwSupportWorkerCoreExperience(int id);
    }
}
