using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IAdminSupportWorkerService
    {
        IEnumerable<AdminSupportWorker> GetAdminSupportWorker();
        AdminSupportWorker GetAdminSupportWorkerById(int id);
        AdminSupportWorker AddAdminSupportWorker(AdminSupportWorker AdminSupportWorker);
        AdminSupportWorker UpdateAdminSupportWorker(AdminSupportWorker AdminSupportWorker);
        AdminSupportWorker DeleteAdminSupportWorker(int id);
    }
}
