using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwTimesheetService : ISwTimesheetService
    {
        HelperBeesContext dbContext;
        public SwTimesheetService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwTimesheet AddSwTimesheet(SwTimesheet SwTimesheet)
        {
            if (SwTimesheet != null)
            {
                dbContext.SwTimesheets.Add(SwTimesheet);
                dbContext.SaveChanges();
                return SwTimesheet;
            }
            return null;
        }

        public SwTimesheet DeleteSwTimesheet(int id)
        {
            var SwTimesheets = dbContext.SwTimesheets.FirstOrDefault(x => x.TimesheetId == id);
            dbContext.Entry(SwTimesheets).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwTimesheets;
        }

        public IEnumerable<SwTimesheet> GetSwTimesheet(int? supportWorkerId, int? timesheetStatusId)
        {
            var SwTimesheets = dbContext.SwTimesheets.Where(x =>
                (x.SupportWorkerId == supportWorkerId || supportWorkerId == null) &&
                (x.TimesheetStatusId == timesheetStatusId || timesheetStatusId == null)
            );
            return SwTimesheets;
        }

        public SwTimesheet GetSwTimesheetById(int id)
        {
            var SwTimesheets = dbContext.SwTimesheets.FirstOrDefault(x => x.TimesheetId == id);
            return SwTimesheets;
        }

        public SwTimesheet UpdateSwTimesheet(SwTimesheet SwTimesheets)
        {
            dbContext.Entry(SwTimesheets).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwTimesheets;
        }
    }
}
