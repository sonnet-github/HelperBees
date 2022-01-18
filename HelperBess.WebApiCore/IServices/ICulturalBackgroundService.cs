using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ICulturalBackgroundService
    {
        IEnumerable<CulturalBackground> GetCulturalBackground();
        CulturalBackground GetCulturalBackgroundById(int id);
        CulturalBackground AddCulturalBackground(CulturalBackground CulturalBackground);
        CulturalBackground UpdateCulturalBackground(CulturalBackground CulturalBackground);
        CulturalBackground DeleteCulturalBackground(int id);
    }
}
