using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwQualificationService
    {
        IEnumerable<SwQualification> GetSwQualification();
        SwQualification GetSwQualificationById(int id);
        IEnumerable<SwQualification> GetSwQualificationByServiceId(int serviceid);
        SwQualification AddSwQualification(SwQualification SwQualification);
        SwQualification UpdateSwQualification(SwQualification SwQualification);
        SwQualification DeleteSwQualification(int id);
    }
}
