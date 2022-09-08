using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IAdminAccountHolderService
    {
        IEnumerable<AdminAccountHolder> GetAdminAccountHolder();
        AdminAccountHolder GetAdminAccountHolderById(int id);
        AdminAccountHolder AddAdminAccountHolder(AdminAccountHolder AdminAccountHolder);
        AdminAccountHolder UpdateAdminAccountHolder(AdminAccountHolder AdminAccountHolder);
        AdminAccountHolder DeleteAdminAccountHolder(int id);
    }
}
