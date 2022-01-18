using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerServiceService : ISwSupportWorkerServiceService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerServiceService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public HelperBess.WebApiCore.Models.SwSupportWorkerService AddSwSupportWorkerService(HelperBess.WebApiCore.Models.SwSupportWorkerService swSupportWorker)
        {
            if (swSupportWorker != null)
            {
                dbContext.SwSupportWorkerServices.Add(swSupportWorker);
                dbContext.SaveChanges();
                return swSupportWorker;
            }
            return null;

            //throw new NotImplementedException();
        }

        public HelperBess.WebApiCore.Models.SwSupportWorkerService DeleteSwSupportWorkerService(int id)
        {
            var SwSupportWorkerService = dbContext.SwSupportWorkerServices.FirstOrDefault(x => x.SupportWorkerId == id);
            dbContext.Entry(SwSupportWorkerService).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerService;
        }

        public IEnumerable<HelperBess.WebApiCore.Models.SwSupportWorkerService> GetSwSupportWorkerService()
        {
            var SwSupportWorkerService = dbContext.SwSupportWorkerServices.ToList();
            return SwSupportWorkerService;

            //throw new NotImplementedException();
        }

        public HelperBess.WebApiCore.Models.SwSupportWorkerService GetSwSupportWorkerServiceById(int id)
        {
            var SwSupportWorkerService = dbContext.SwSupportWorkerServices.FirstOrDefault(x => x.SupportWorkerId == id);
            return SwSupportWorkerService;
        }

        public HelperBess.WebApiCore.Models.SwSupportWorkerService UpdateSwSupportWorkerService(HelperBess.WebApiCore.Models.SwSupportWorkerService SwSupportWorkerService)
        {
            dbContext.Entry(SwSupportWorkerService).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerService;
        }
    }
}
