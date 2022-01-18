using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerOtherQualificationService
    {
        IEnumerable<SwSupportWorkerOtherQualification> GetSwSupportWorkerOtherQualification();
        SwSupportWorkerOtherQualification GetSwSupportWorkerOtherQualificationById(int id);
        SwSupportWorkerOtherQualification AddSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification SwSupportWorkerOtherQualification);
        SwSupportWorkerOtherQualification UpdateSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification SwSupportWorkerOtherQualification);
        SwSupportWorkerOtherQualification DeleteSwSupportWorkerOtherQualification(int id);
    }
}
