using HelperBess.WebApiCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClAccountHolderService
    {
        IEnumerable<ClAccountHolder> GetClAccountHolder();
        ClAccountHolder GetClAccountHolderById(int id);
        ClAccountHolder AddClAccountHolder(ClAccountHolder clAccountHolder);
        ClAccountHolder UpdateClAccountHolder(ClAccountHolder clAccountHolder);
        ClAccountHolder DeleteClAccountHolder(int id);
    }
}
