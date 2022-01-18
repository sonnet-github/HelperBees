using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClInterestService
    {
        IEnumerable<ClInterest> GetClInterest();
        ClInterest GetClInterestById(int id);
        ClInterest AddClInterest(ClInterest ClInterest);
        ClInterest UpdateClInterest(ClInterest ClInterest);
        ClInterest DeleteClInterest(int id);
    }
}
