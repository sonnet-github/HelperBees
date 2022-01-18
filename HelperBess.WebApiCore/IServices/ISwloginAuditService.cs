using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwloginAuditService
    {
        IEnumerable<SwloginAudit> GetSwloginAudit();
        SwloginAudit GetSwloginAuditById(int id);
        SwloginAudit AddSwloginAudit(SwloginAudit SwloginAudit);
        SwloginAudit UpdateSwloginAudit(SwloginAudit SwloginAudit);
        SwloginAudit DeleteSwloginAudit(int id);
    }
}
