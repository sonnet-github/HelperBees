using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class AdminSupportWorkerService : IAdminSupportWorkerService
    {
        HelperBeesContext dbContext;
        public AdminSupportWorkerService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public AdminSupportWorker AddAdminSupportWorker(AdminSupportWorker AdminSupportWorker)
        {
            if (AdminSupportWorker != null)
            {
                dbContext.AdminSupportWorkers.Add(AdminSupportWorker);
                dbContext.SaveChanges();
                return AdminSupportWorker;
            }
            return null;
        }

        public AdminSupportWorker DeleteAdminSupportWorker(int id)
        {
            var AdminSupportWorkers = dbContext.AdminSupportWorkers.FirstOrDefault(x => x.AdminSupportWorkerId == id);
            dbContext.Entry(AdminSupportWorkers).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return AdminSupportWorkers;
        }

        public IEnumerable<AdminSupportWorker> GetAdminSupportWorker()
        {
            var AdminSupportWorkers = dbContext.AdminSupportWorkers.ToList();
            return AdminSupportWorkers;
        }

        public AdminSupportWorker GetAdminSupportWorkerById(int id)
        {
            var AdminSupportWorkers = dbContext.AdminSupportWorkers.FirstOrDefault(x => x.AdminSupportWorkerId == id);
            return AdminSupportWorkers;
        }

        public AdminSupportWorker UpdateAdminSupportWorker(AdminSupportWorker AdminSupportWorkers)
        {
            dbContext.Entry(AdminSupportWorkers).State = EntityState.Modified;
            dbContext.SaveChanges();
            return AdminSupportWorkers;
        }
    }
}
