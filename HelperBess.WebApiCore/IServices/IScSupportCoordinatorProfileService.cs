using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IScSupportCoordinatorProfileService
    {
        IEnumerable<ScSupportCoordinatorProfile> GetScSupportCoordinatorProfile();
        ScSupportCoordinatorProfile GetScSupportCoordinatorProfileById(int id);
        ScSupportCoordinatorProfile GetScSupportCoordinatorProfileByCoordinatorId(int id);
        ScSupportCoordinatorProfile AddScSupportCoordinatorProfile(ScSupportCoordinatorProfile ScSupportCoordinatorProfile);
        ScSupportCoordinatorProfile UpdateScSupportCoordinatorProfile(ScSupportCoordinatorProfile ScSupportCoordinatorProfile);
        ScSupportCoordinatorProfile DeleteScSupportCoordinatorProfile(int id);
    }
}
