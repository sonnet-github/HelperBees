using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IScimpersonisationLoginAuditService
    {
        IEnumerable<ScimpersonisationLoginAudit> GetScimpersonisationLoginAudit();
        ScimpersonisationLoginAudit GetScimpersonisationLoginAuditById(int id);
        ScimpersonisationLoginAudit AddScimpersonisationLoginAudit(ScimpersonisationLoginAudit ScimpersonisationLoginAudit);
        ScimpersonisationLoginAudit UpdateScimpersonisationLoginAudit(ScimpersonisationLoginAudit ScimpersonisationLoginAudit);
        ScimpersonisationLoginAudit DeleteScimpersonisationLoginAudit(int id);
    }
}
