using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IScSupportCoordinatorService
    {
        IEnumerable<ScSupportCoordinator> GetScSupportCoordinator();
        ScSupportCoordinator GetScSupportCoordinatorById(int id);
        ScSupportCoordinator GetScSupportCoordinatorByEmail(string emailaddress);
        ScSupportCoordinator AddScSupportCoordinator(ScSupportCoordinator ScSupportCoordinator);
        ScSupportCoordinator UpdateScSupportCoordinator(ScSupportCoordinator ScSupportCoordinator);
        ScSupportCoordinator DeleteScSupportCoordinator(int id);
    }
}
