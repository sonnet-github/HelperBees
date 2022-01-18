using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwTimesheetIncidentService
    {
        IEnumerable<SwTimesheetIncident> GetSwTimesheetIncident();
        SwTimesheetIncident GetSwTimesheetIncidentById(int id);
        SwTimesheetIncident AddSwTimesheetIncident(SwTimesheetIncident SwTimesheetIncident);
        SwTimesheetIncident UpdateSwTimesheetIncident(SwTimesheetIncident SwTimesheetIncident);
        SwTimesheetIncident DeleteSwTimesheetIncident(int id);
    }
}
