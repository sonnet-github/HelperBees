using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerAdditionalTrainingService : ISwSupportWorkerAdditionalTrainingService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerAdditionalTrainingService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerAdditionalTraining AddSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining SwSupportWorkerAdditionalTraining)
        {
            if (SwSupportWorkerAdditionalTraining != null)
            {
                dbContext.SwSupportWorkerAdditionalTrainings.Add(SwSupportWorkerAdditionalTraining);
                dbContext.SaveChanges();
                return SwSupportWorkerAdditionalTraining;
            }
            return null;
        }

        public SwSupportWorkerAdditionalTraining DeleteSwSupportWorkerAdditionalTraining(int id)
        {
            var SwSupportWorkerAdditionalTrainings = dbContext.SwSupportWorkerAdditionalTrainings.FirstOrDefault(x => x.SupportWorkerAdditionalTrainingId == id);
            dbContext.Entry(SwSupportWorkerAdditionalTrainings).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerAdditionalTrainings;
        }

        public IEnumerable<SwSupportWorkerAdditionalTraining> GetSwSupportWorkerAdditionalTraining()
        {
            var SwSupportWorkerAdditionalTrainings = dbContext.SwSupportWorkerAdditionalTrainings.ToList();
            return SwSupportWorkerAdditionalTrainings;
        }

        public SwSupportWorkerAdditionalTraining GetSwSupportWorkerAdditionalTrainingById(int id)
        {
            var SwSupportWorkerAdditionalTrainings = dbContext.SwSupportWorkerAdditionalTrainings.FirstOrDefault(x => x.SupportWorkerAdditionalTrainingId == id);
            return SwSupportWorkerAdditionalTrainings;
        }

        public SwSupportWorkerAdditionalTraining UpdateSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining SwSupportWorkerAdditionalTrainings)
        {
            dbContext.Entry(SwSupportWorkerAdditionalTrainings).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerAdditionalTrainings;
        }

        public IEnumerable<SwSupportWorkerAdditionalTraining> GetSwSupportWorkerAdditionalTrainingBySupportWorkerId(int supportWorkerId)
        {
            var SwSupportWorkerAdditionalTrainings = dbContext.SwSupportWorkerAdditionalTrainings.Where(x => x.SupportWorkerId == supportWorkerId);
            return SwSupportWorkerAdditionalTrainings;
        }
    }
}
