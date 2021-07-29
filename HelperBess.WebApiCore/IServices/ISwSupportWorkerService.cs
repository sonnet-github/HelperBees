using HelperBess.WebApiCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerService
    {
        IEnumerable<SwSupportWorker> GetSwSupportWorker();
        SwSupportWorker GetSwSupportWorkerById(int id);
        SwSupportWorker AddSwSupportWorker(SwSupportWorker swSupportWorker);
        SwSupportWorker UpdateSwSupportWorker(SwSupportWorker swSupportWorker);
        SwSupportWorker DeleteSwSupportWorker(int id);
    }
}
