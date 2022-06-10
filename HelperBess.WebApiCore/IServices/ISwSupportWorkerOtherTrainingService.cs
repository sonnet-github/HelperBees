using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerOtherTrainingService
    {
        IEnumerable<SwSupportWorkerOtherTraining> GetSwSupportWorkerOtherTraining();
        SwSupportWorkerOtherTraining GetSwSupportWorkerOtherTrainingById(int id);

        IEnumerable<SwSupportWorkerOtherTraining> GetSwSupportWorkerOtherTrainingBySupportWorkerId(int supportWorkerId);

        SwSupportWorkerOtherTraining AddSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining SwSupportWorkerOtherTraining);
        SwSupportWorkerOtherTraining UpdateSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining SwSupportWorkerOtherTraining);
        SwSupportWorkerOtherTraining DeleteSwSupportWorkerOtherTraining(int id);
    }
}
