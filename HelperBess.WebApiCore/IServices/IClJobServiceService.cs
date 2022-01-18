using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClJobServiceService
    {
        IEnumerable<ClJobService> GetClJobService();
        ClJobService GetClJobServiceById(int id);
        ClJobService AddClJobService(ClJobService ClJobService);
        ClJobService UpdateClJobService(ClJobService ClJobService);
        ClJobService DeleteClJobService(int id);
    }
}
