using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class StatusService : IStatusService
    {
        HelperBeesContext dbContext;
        public StatusService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public Status AddStatus(Status Status)
        {
            if (Status != null)
            {
                dbContext.Statuses.Add(Status);
                dbContext.SaveChanges();
                return Status;
            }
            return null;
        }

        public Status DeleteStatus(int id)
        {
            var Statuss = dbContext.Statuses.FirstOrDefault(x => x.StatusId == id);
            dbContext.Entry(Statuss).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return Statuss;
        }

        public IEnumerable<Status> GetStatus()
        {
            var Statuss = dbContext.Statuses.ToList();
            return Statuss;
        }

        public Status GetStatusById(int id)
        {
            var Statuss = dbContext.Statuses.FirstOrDefault(x => x.StatusId == id);
            return Statuss;
        }

        public Status UpdateStatus(Status Statuss)
        {
            dbContext.Entry(Statuss).State = EntityState.Modified;
            dbContext.SaveChanges();
            return Statuss;
        }
    }
}
