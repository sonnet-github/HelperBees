using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerCoreExperienceService
    {
        IEnumerable<SwSupportWorkerCoreExperience> GetSwSupportWorkerCoreExperience();
        SwSupportWorkerCoreExperience GetSwSupportWorkerCoreExperienceById(int id);

        IEnumerable<SwSupportWorkerCoreExperience> GetSwSupportWorkerCoreExperienceBySupportWorkerId(int supportWorkerId);

        SwSupportWorkerCoreExperience AddSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience SwSupportWorkerCoreExperience);
        SwSupportWorkerCoreExperience UpdateSwSupportWorkerCoreExperience(SwSupportWorkerCoreExperience SwSupportWorkerCoreExperience);
        SwSupportWorkerCoreExperience DeleteSwSupportWorkerCoreExperience(int id);
        IEnumerable<SwSupportWorkerCoreExperience> DeleteSwSupportWorkerCoreExperiencebySupportWorkerID(int SupportWorkerId);
     


    }
}
