using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerService : ISwSupportWorkerService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorker AddSwSupportWorker(SwSupportWorker swSupportWorker)
        {
            if (swSupportWorker != null)
            {
                dbContext.SwSupportWorkers.Add(swSupportWorker);
                dbContext.SaveChanges();
                return swSupportWorker;
            }
            return null;

            //throw new NotImplementedException();
        }

        public SwSupportWorker DeleteSwSupportWorker(int id)
        {
            var swSupportWorker = dbContext.SwSupportWorkers.FirstOrDefault(x => x.SupportWorkerId == id);
            dbContext.Entry(swSupportWorker).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return swSupportWorker;
        }

        //[Microsoft.AspNetCore.Mvc.HttpGet]
        public SwSupportWorker GetSwSupportWorkerByLogin(string email, string password)
        {
            var swSupportWorker = dbContext.SwSupportWorkers.FirstOrDefault(x => x.EmailAddress == email && x.Password == password);
            return swSupportWorker;

            //throw new NotImplementedException();
        }

        public SwSupportWorker GetSwSupportWorkerById(int id)
        {
            var swSupportWorker = dbContext.SwSupportWorkers.FirstOrDefault(x => x.SupportWorkerId == id);
            return swSupportWorker;
        }

        public IEnumerable<SwSupportWorker> GetSwSupportWorkerByStatusId(string status)
        {
            var swSupportWorker = dbContext.SwSupportWorkers.Where(x => x.Status.Status1 == status);
            return swSupportWorker;
        }

        public SwSupportWorker UpdateSwSupportWorker(SwSupportWorker swSupportWorker)
        {
            dbContext.Entry(swSupportWorker).State = EntityState.Modified;
            dbContext.SaveChanges();
            return swSupportWorker;
        }
    }
}
