using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerQualificationService
    {
        IEnumerable<SwSupportWorkerQualification> GetSwSupportWorkerQualification();
        SwSupportWorkerQualification GetSwSupportWorkerQualificationById(int id);

        IEnumerable<SwSupportWorkerQualification> GetSwSupportWorkerQualificationBySupportWorkerId(int supportWorkerId);

        SwSupportWorkerQualification AddSwSupportWorkerQualification(SwSupportWorkerQualification SwSupportWorkerQualification);
        SwSupportWorkerQualification UpdateSwSupportWorkerQualification(SwSupportWorkerQualification SwSupportWorkerQualification);
        SwSupportWorkerQualification DeleteSwSupportWorkerQualification(int id);
    }
}
