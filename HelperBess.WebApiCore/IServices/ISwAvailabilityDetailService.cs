using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwAvailabilityDetailService
    {
        IEnumerable<SwAvailabilityDetail> GetSwAvailabilityDetail();
        SwAvailabilityDetail GetSwAvailabilityDetailById(int id);
        SwAvailabilityDetail AddSwAvailabilityDetail(SwAvailabilityDetail SwAvailabilityDetail);
        SwAvailabilityDetail UpdateSwAvailabilityDetail(SwAvailabilityDetail SwAvailabilityDetail);
        SwAvailabilityDetail DeleteSwAvailabilityDetail(int id);
        IEnumerable<SwAvailabilityDetail> GetSwAvailabilityDetailbySupportWorkerId(int supportWorkerId);
        IEnumerable<SwAvailabilityDetail> DeleteSwAvailabilityDetailbySupportWorkerId(int SupportWorkerId);
    }
}
