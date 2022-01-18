using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwTimesheetStatusService
    {
        IEnumerable<SwTimesheetStatus> GetSwTimesheetStatus();
        SwTimesheetStatus GetSwTimesheetStatusById(int id);
        SwTimesheetStatus AddSwTimesheetStatus(SwTimesheetStatus SwTimesheetStatus);
        SwTimesheetStatus UpdateSwTimesheetStatus(SwTimesheetStatus SwTimesheetStatus);
        SwTimesheetStatus DeleteSwTimesheetStatus(int id);
    }
}
