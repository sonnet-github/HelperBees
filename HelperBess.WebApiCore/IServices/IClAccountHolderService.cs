using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClAccountHolderService
    {
        ClAccountHolder GetClAccountHolderByEmailAddress(string emailaddress);
        IEnumerable<ClAccountHolder> GetClAccountHolder(string emailaddress, string password);
        ClAccountHolder GetClAccountHolderById(int id);
        ClAccountHolder AddClAccountHolder(ClAccountHolder clAccountHolder);
        ClAccountHolder UpdateClAccountHolder(ClAccountHolder clAccountHolder);
        ClAccountHolder DeleteClAccountHolder(int id);
    }
}
