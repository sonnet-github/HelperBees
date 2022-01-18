using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerOtherTrainingService : ISwSupportWorkerOtherTrainingService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerOtherTrainingService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerOtherTraining AddSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining SwSupportWorkerOtherTraining)
        {
            if (SwSupportWorkerOtherTraining != null)
            {
                dbContext.SwSupportWorkerOtherTrainings.Add(SwSupportWorkerOtherTraining);
                dbContext.SaveChanges();
                return SwSupportWorkerOtherTraining;
            }
            return null;
        }

        public SwSupportWorkerOtherTraining DeleteSwSupportWorkerOtherTraining(int id)
        {
            var SwSupportWorkerOtherTrainings = dbContext.SwSupportWorkerOtherTrainings.FirstOrDefault(x => x.SupportWorkerOtherTrainingId == id);
            dbContext.Entry(SwSupportWorkerOtherTrainings).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerOtherTrainings;
        }

        public IEnumerable<SwSupportWorkerOtherTraining> GetSwSupportWorkerOtherTraining()
        {
            var SwSupportWorkerOtherTrainings = dbContext.SwSupportWorkerOtherTrainings.ToList();
            return SwSupportWorkerOtherTrainings;
        }

        public SwSupportWorkerOtherTraining GetSwSupportWorkerOtherTrainingById(int id)
        {
            var SwSupportWorkerOtherTrainings = dbContext.SwSupportWorkerOtherTrainings.FirstOrDefault(x => x.SupportWorkerOtherTrainingId == id);
            return SwSupportWorkerOtherTrainings;
        }

        public SwSupportWorkerOtherTraining UpdateSwSupportWorkerOtherTraining(SwSupportWorkerOtherTraining SwSupportWorkerOtherTrainings)
        {
            dbContext.Entry(SwSupportWorkerOtherTrainings).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerOtherTrainings;
        }
    }
}
