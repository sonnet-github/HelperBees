using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClloginAuditService
    {
        IEnumerable<ClloginAudit> GetClloginAudit();
        ClloginAudit GetClloginAuditById(int id);
        ClloginAudit AddClloginAudit(ClloginAudit ClloginAudit);
        ClloginAudit UpdateClloginAudit(ClloginAudit ClloginAudit);
        ClloginAudit DeleteClloginAudit(int id);
    }
}
