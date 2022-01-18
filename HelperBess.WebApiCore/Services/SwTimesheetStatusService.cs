using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwTimesheetStatusService : ISwTimesheetStatusService
    {
        HelperBeesContext dbContext;
        public SwTimesheetStatusService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwTimesheetStatus AddSwTimesheetStatus(SwTimesheetStatus SwTimesheetStatus)
        {
            if (SwTimesheetStatus != null)
            {
                dbContext.SwTimesheetStatuses.Add(SwTimesheetStatus);
                dbContext.SaveChanges();
                return SwTimesheetStatus;
            }
            return null;
        }

        public SwTimesheetStatus DeleteSwTimesheetStatus(int id)
        {
            var SwTimesheetStatuss = dbContext.SwTimesheetStatuses.FirstOrDefault(x => x.TimesheetStatusId == id);
            dbContext.Entry(SwTimesheetStatuss).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwTimesheetStatuss;
        }

        public IEnumerable<SwTimesheetStatus> GetSwTimesheetStatus()
        {
            var SwTimesheetStatuss = dbContext.SwTimesheetStatuses.ToList();
            return SwTimesheetStatuss;
        }

        public SwTimesheetStatus GetSwTimesheetStatusById(int id)
        {
            var SwTimesheetStatuss = dbContext.SwTimesheetStatuses.FirstOrDefault(x => x.TimesheetStatusId == id);
            return SwTimesheetStatuss;
        }

        public SwTimesheetStatus UpdateSwTimesheetStatus(SwTimesheetStatus SwTimesheetStatuss)
        {
            dbContext.Entry(SwTimesheetStatuss).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwTimesheetStatuss;
        }
    }
}
