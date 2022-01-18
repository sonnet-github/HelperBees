using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwTimesheetIncidentService : ISwTimesheetIncidentService
    {
        HelperBeesContext dbContext;
        public SwTimesheetIncidentService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwTimesheetIncident AddSwTimesheetIncident(SwTimesheetIncident SwTimesheetIncident)
        {
            if (SwTimesheetIncident != null)
            {
                dbContext.SwTimesheetIncidents.Add(SwTimesheetIncident);
                dbContext.SaveChanges();
                return SwTimesheetIncident;
            }
            return null;
        }

        public SwTimesheetIncident DeleteSwTimesheetIncident(int id)
        {
            var SwTimesheetIncidents = dbContext.SwTimesheetIncidents.FirstOrDefault(x => x.IncidentId == id);
            dbContext.Entry(SwTimesheetIncidents).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwTimesheetIncidents;
        }

        public IEnumerable<SwTimesheetIncident> GetSwTimesheetIncident()
        {
            var SwTimesheetIncidents = dbContext.SwTimesheetIncidents.ToList();
            return SwTimesheetIncidents;
        }

        public SwTimesheetIncident GetSwTimesheetIncidentById(int id)
        {
            var SwTimesheetIncidents = dbContext.SwTimesheetIncidents.FirstOrDefault(x => x.IncidentId == id);
            return SwTimesheetIncidents;
        }

        public SwTimesheetIncident UpdateSwTimesheetIncident(SwTimesheetIncident SwTimesheetIncidents)
        {
            dbContext.Entry(SwTimesheetIncidents).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwTimesheetIncidents;
        }
    }
}
