using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClOtherContactService
    {
        IEnumerable<ClOtherContact> GetClOtherContact();
        ClOtherContact GetClOtherContactById(int id);
        ClOtherContact AddClOtherContact(ClOtherContact ClOtherContact);
        ClOtherContact UpdateClOtherContact(ClOtherContact ClOtherContact);
        ClOtherContact DeleteClOtherContact(int id);
    }
}
