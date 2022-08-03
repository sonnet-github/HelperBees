using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerService
    {
        SwSupportWorker GetSwSupportWorkerByLogin(string email, string password);
        SwSupportWorker GetSwSupportWorkerById(int id);
        IEnumerable<SwSupportWorker> GetSwSupportWorkerByStatusId(string status);
        SwSupportWorker AddSwSupportWorker(SwSupportWorker swSupportWorker);
        SwSupportWorker UpdateSwSupportWorker(SwSupportWorker swSupportWorker);
        SwSupportWorker DeleteSwSupportWorker(int id);
    }
}
