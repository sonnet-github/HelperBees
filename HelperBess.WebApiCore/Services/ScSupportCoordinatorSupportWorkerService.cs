using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ScSupportCoordinatorSupportWorkerService : IScSupportCoordinatorSupportWorkerService
    {
        HelperBeesContext dbContext;
        public ScSupportCoordinatorSupportWorkerService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ScSupportCoordinatorSupportWorker AddScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker ScSupportCoordinatorSupportWorker)
        {
            if (ScSupportCoordinatorSupportWorker != null)
            {
                dbContext.ScSupportCoordinatorSupportWorkers.Add(ScSupportCoordinatorSupportWorker);
                dbContext.SaveChanges();
                return ScSupportCoordinatorSupportWorker;
            }
            return null;
        }

        public ScSupportCoordinatorSupportWorker DeleteScSupportCoordinatorSupportWorker(int id)
        {
            var ScSupportCoordinatorSupportWorkers = dbContext.ScSupportCoordinatorSupportWorkers.FirstOrDefault(x => x.UpportCoordinatorSupportWorkerId == id);
            dbContext.Entry(ScSupportCoordinatorSupportWorkers).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ScSupportCoordinatorSupportWorkers;
        }

        public IEnumerable<ScSupportCoordinatorSupportWorker> GetScSupportCoordinatorSupportWorker()
        {
            var ScSupportCoordinatorSupportWorkers = dbContext.ScSupportCoordinatorSupportWorkers.ToList();
            return ScSupportCoordinatorSupportWorkers;
        }

        public ScSupportCoordinatorSupportWorker GetScSupportCoordinatorSupportWorkerById(int id)
        {
            var ScSupportCoordinatorSupportWorkers = dbContext.ScSupportCoordinatorSupportWorkers.FirstOrDefault(x => x.UpportCoordinatorSupportWorkerId == id);
            return ScSupportCoordinatorSupportWorkers;
        }

        public ScSupportCoordinatorSupportWorker UpdateScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker ScSupportCoordinatorSupportWorkers)
        {
            dbContext.Entry(ScSupportCoordinatorSupportWorkers).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ScSupportCoordinatorSupportWorkers;
        }
    }
}
