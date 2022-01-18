using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwEducationService
    {
        IEnumerable<SwEducation> GetSwEducation();
        SwEducation GetSwEducationById(int id);
        SwEducation AddSwEducation(SwEducation SwEducation);
        SwEducation UpdateSwEducation(SwEducation SwEducation);
        SwEducation DeleteSwEducation(int id);
    }
}
