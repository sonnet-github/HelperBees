using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IReligionService
    {
        IEnumerable<Religion> GetReligion();
        Religion GetReligionById(int id);
        Religion AddReligion(Religion Religion);
        Religion UpdateReligion(Religion Religion);
        Religion DeleteReligion(int id);
    }
}
