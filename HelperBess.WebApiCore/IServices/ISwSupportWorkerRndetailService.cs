using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerRndetailService
    {
        IEnumerable<SwSupportWorkerRndetail> GetSwSupportWorkerRndetail();
        SwSupportWorkerRndetail GetSwSupportWorkerRndetailById(int id);

        IEnumerable<SwSupportWorkerRndetail> GetSwSupportWorkerRndetailBySupportWorkerId(int supportWorkerId);

        SwSupportWorkerRndetail AddSwSupportWorkerRndetail(SwSupportWorkerRndetail SwSupportWorkerRndetail);
        SwSupportWorkerRndetail UpdateSwSupportWorkerRndetail(SwSupportWorkerRndetail SwSupportWorkerRndetail);
        SwSupportWorkerRndetail DeleteSwSupportWorkerRndetail(int id);
    }
}
