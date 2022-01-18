using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerQualificationService
    {
        IEnumerable<SwSupportWorkerQualification> GetSwSupportWorkerQualification();
        SwSupportWorkerQualification GetSwSupportWorkerQualificationById(int id);
        SwSupportWorkerQualification AddSwSupportWorkerQualification(SwSupportWorkerQualification SwSupportWorkerQualification);
        SwSupportWorkerQualification UpdateSwSupportWorkerQualification(SwSupportWorkerQualification SwSupportWorkerQualification);
        SwSupportWorkerQualification DeleteSwSupportWorkerQualification(int id);
    }
}
