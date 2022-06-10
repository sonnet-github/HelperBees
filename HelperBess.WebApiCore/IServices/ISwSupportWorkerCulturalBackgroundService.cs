using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerCulturalBackgroundService
    {
        IEnumerable<SwSupportWorkerCulturalBackground> GetSwSupportWorkerCulturalBackground();
        SwSupportWorkerCulturalBackground GetSwSupportWorkerCulturalBackgroundById(int id);

        IEnumerable<SwSupportWorkerCulturalBackground> GetSwSupportWorkerCulturalBackgroundBySupportWorkerId(int supportWorkerId);

        SwSupportWorkerCulturalBackground AddSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground SwSupportWorkerCulturalBackground);
        SwSupportWorkerCulturalBackground UpdateSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground SwSupportWorkerCulturalBackground);
        SwSupportWorkerCulturalBackground DeleteSwSupportWorkerCulturalBackground(int id);
    }
}
