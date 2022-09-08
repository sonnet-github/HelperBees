using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IAdministratorProfileService
    {
        IEnumerable<AdministratorProfile> GetAdministratorProfile();
        AdministratorProfile GetAdministratorProfileById(int id);
        AdministratorProfile GetAdministratorProfileByAdminId(int adminid);
        AdministratorProfile AddAdministratorProfile(AdministratorProfile AdministratorProfile);
        AdministratorProfile UpdateAdministratorProfile(AdministratorProfile AdministratorProfile);
        AdministratorProfile DeleteAdministratorProfile(int id);
    }
}
