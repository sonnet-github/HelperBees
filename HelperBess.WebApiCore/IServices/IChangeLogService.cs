using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IChangeLogService
    {
        IEnumerable<ChangeLog> GetChangeLog();
        ChangeLog GetChangeLogById(int id);
        ChangeLog AddChangeLog(ChangeLog ChangeLog);
        ChangeLog UpdateChangeLog(ChangeLog ChangeLog);
        ChangeLog DeleteChangeLog(int id);
    }
}
