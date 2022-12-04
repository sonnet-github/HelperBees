using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerServiceService
    {
        IEnumerable<SwSupportWorkerService> GetSwSupportWorkerService();
        SwSupportWorkerService GetSwSupportWorkerServiceById(int id);
        IEnumerable<SwSupportWorkerService> GetSwSupportWorkerServiceBySupportWorkerId(int supportWorkerId);
        SwSupportWorkerService AddSwSupportWorkerService(SwSupportWorkerService SwSupportWorkerService);
        SwSupportWorkerService UpdateSwSupportWorkerService(SwSupportWorkerService SwSupportWorkerService);
        SwSupportWorkerService DeleteSwSupportWorkerService(int id);
        IEnumerable<SwSupportWorkerService> DeleteSwSupportWorkerServicebySupportWorkerID(int supportWorkerId);

    }
}
