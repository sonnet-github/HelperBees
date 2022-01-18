using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerQualificationService : ISwSupportWorkerQualificationService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerQualificationService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerQualification AddSwSupportWorkerQualification(SwSupportWorkerQualification SwSupportWorkerQualification)
        {
            if (SwSupportWorkerQualification != null)
            {
                dbContext.SwSupportWorkerQualifications.Add(SwSupportWorkerQualification);
                dbContext.SaveChanges();
                return SwSupportWorkerQualification;
            }
            return null;
        }

        public SwSupportWorkerQualification DeleteSwSupportWorkerQualification(int id)
        {
            var SwSupportWorkerQualifications = dbContext.SwSupportWorkerQualifications.FirstOrDefault(x => x.SupportWorkerQualificationId == id);
            dbContext.Entry(SwSupportWorkerQualifications).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerQualifications;
        }

        public IEnumerable<SwSupportWorkerQualification> GetSwSupportWorkerQualification()
        {
            var SwSupportWorkerQualifications = dbContext.SwSupportWorkerQualifications.ToList();
            return SwSupportWorkerQualifications;
        }

        public SwSupportWorkerQualification GetSwSupportWorkerQualificationById(int id)
        {
            var SwSupportWorkerQualifications = dbContext.SwSupportWorkerQualifications.FirstOrDefault(x => x.SupportWorkerQualificationId == id);
            return SwSupportWorkerQualifications;
        }

        public SwSupportWorkerQualification UpdateSwSupportWorkerQualification(SwSupportWorkerQualification SwSupportWorkerQualifications)
        {
            dbContext.Entry(SwSupportWorkerQualifications).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerQualifications;
        }
    }
}
