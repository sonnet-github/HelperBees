using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IStatusService
    {
        IEnumerable<Status> GetStatus();
        Status GetStatusById(int id);
        Status AddStatus(Status Status);
        Status UpdateStatus(Status Status);
        Status DeleteStatus(int id);
    }
}
