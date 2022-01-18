using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IScloginAuditService
    {
        IEnumerable<ScloginAudit> GetScloginAudit();
        ScloginAudit GetScloginAuditById(int id);
        ScloginAudit AddScloginAudit(ScloginAudit ScloginAudit);
        ScloginAudit UpdateScloginAudit(ScloginAudit ScloginAudit);
        ScloginAudit DeleteScloginAudit(int id);
    }
}
