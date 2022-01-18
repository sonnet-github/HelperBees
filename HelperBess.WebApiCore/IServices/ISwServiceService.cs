using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwServiceService
    {
        IEnumerable<SwService> GetSwService();
        SwService GetSwServiceById(int id);
        SwService AddSwService(SwService SwService);
        SwService UpdateSwService(SwService SwService);
        SwService DeleteSwService(int id);
    }
}
