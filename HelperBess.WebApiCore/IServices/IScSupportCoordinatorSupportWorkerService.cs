using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IScSupportCoordinatorSupportWorkerService
    {
        IEnumerable<ScSupportCoordinatorSupportWorker> GetScSupportCoordinatorSupportWorker();
        ScSupportCoordinatorSupportWorker GetScSupportCoordinatorSupportWorkerById(int id);
        ScSupportCoordinatorSupportWorker AddScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker ScSupportCoordinatorSupportWorker);
        ScSupportCoordinatorSupportWorker UpdateScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker ScSupportCoordinatorSupportWorker);
        ScSupportCoordinatorSupportWorker DeleteScSupportCoordinatorSupportWorker(int id);
    }
}
