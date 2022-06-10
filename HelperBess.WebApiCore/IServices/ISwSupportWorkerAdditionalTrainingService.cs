using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerAdditionalTrainingService
    {
        IEnumerable<SwSupportWorkerAdditionalTraining> GetSwSupportWorkerAdditionalTraining();
        SwSupportWorkerAdditionalTraining GetSwSupportWorkerAdditionalTrainingById(int id);

        IEnumerable<SwSupportWorkerAdditionalTraining> GetSwSupportWorkerAdditionalTrainingBySupportWorkerId(int supportWorkerId);

        SwSupportWorkerAdditionalTraining AddSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining SwSupportWorkerAdditionalTraining);
        SwSupportWorkerAdditionalTraining UpdateSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining SwSupportWorkerAdditionalTraining);
        SwSupportWorkerAdditionalTraining DeleteSwSupportWorkerAdditionalTraining(int id);
    }
}
