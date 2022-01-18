using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwTimesheetService
    {
        IEnumerable<SwTimesheet> GetSwTimesheet(int? supportWorkerId, int? timesheetStatusId);
        SwTimesheet GetSwTimesheetById(int id);
        SwTimesheet AddSwTimesheet(SwTimesheet SwTimesheet);
        SwTimesheet UpdateSwTimesheet(SwTimesheet SwTimesheet);
        SwTimesheet DeleteSwTimesheet(int id);
    }
}
