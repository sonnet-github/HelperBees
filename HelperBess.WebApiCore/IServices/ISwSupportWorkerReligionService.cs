using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerReligionService
    {
        IEnumerable<SwSupportWorkerReligion> GetSwSupportWorkerReligion();
        SwSupportWorkerReligion GetSwSupportWorkerReligionById(int id);

        IEnumerable<SwSupportWorkerReligion> GetSwSupportWorkerReligionBySupportWorkerId(int supportWorkerId);

        SwSupportWorkerReligion AddSwSupportWorkerReligion(SwSupportWorkerReligion SwSupportWorkerReligion);
        SwSupportWorkerReligion UpdateSwSupportWorkerReligion(SwSupportWorkerReligion SwSupportWorkerReligion);
        SwSupportWorkerReligion DeleteSwSupportWorkerReligion(int id);
    }
}
