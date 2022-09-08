using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IAdministratorService
    {
        IEnumerable<Administrator> GetAdministrator();
        Administrator GetAdministratorById(int id);
        Administrator GetAdministratorByEmail(string EmailAddress);
        Administrator AddAdministrator(Administrator Administrator);
        Administrator UpdateAdministrator(Administrator Administrator);
        Administrator DeleteAdministrator(int id);
    }
}
