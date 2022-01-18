using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerProfileService
    {
        IEnumerable<SwSupportWorkerProfile> GetSwSupportWorkerProfile();
        SwSupportWorkerProfile GetSwSupportWorkerProfileById(int id);
        public IEnumerable<SwSupportWorkerProfile> GetSwSupportWorkerProfileByLocation(string location);
        SwSupportWorkerProfile AddSwSupportWorkerProfile(SwSupportWorkerProfile SwSupportWorkerProfile);
        SwSupportWorkerProfile UpdateSwSupportWorkerProfile(SwSupportWorkerProfile SwSupportWorkerProfile);
        SwSupportWorkerProfile DeleteSwSupportWorkerProfile(int id);
    }
}
