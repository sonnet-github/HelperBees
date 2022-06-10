using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerOtherQualificationService : ISwSupportWorkerOtherQualificationService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerOtherQualificationService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerOtherQualification AddSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification SwSupportWorkerOtherQualification)
        {
            if (SwSupportWorkerOtherQualification != null)
            {
                dbContext.SwSupportWorkerOtherQualifications.Add(SwSupportWorkerOtherQualification);
                dbContext.SaveChanges();
                return SwSupportWorkerOtherQualification;
            }
            return null;
        }

        public SwSupportWorkerOtherQualification DeleteSwSupportWorkerOtherQualification(int id)
        {
            var SwSupportWorkerOtherQualifications = dbContext.SwSupportWorkerOtherQualifications.FirstOrDefault(x => x.SupportWorkerOtherQualificationId == id);
            dbContext.Entry(SwSupportWorkerOtherQualifications).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerOtherQualifications;
        }

        public IEnumerable<SwSupportWorkerOtherQualification> GetSwSupportWorkerOtherQualification()
        {
            var SwSupportWorkerOtherQualifications = dbContext.SwSupportWorkerOtherQualifications.ToList();
            return SwSupportWorkerOtherQualifications;
        }

        public SwSupportWorkerOtherQualification GetSwSupportWorkerOtherQualificationById(int id)
        {
            var SwSupportWorkerOtherQualifications = dbContext.SwSupportWorkerOtherQualifications.FirstOrDefault(x => x.SupportWorkerOtherQualificationId == id);
            return SwSupportWorkerOtherQualifications;
        }

        public SwSupportWorkerOtherQualification UpdateSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification SwSupportWorkerOtherQualifications)
        {
            dbContext.Entry(SwSupportWorkerOtherQualifications).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerOtherQualifications;
        }

        public IEnumerable<SwSupportWorkerOtherQualification> GetSwSupportWorkerOtherQualificationBySupportWorkerId(int supportWorkerId)
        {
            var SwSupportWorkerOtherQualifications = dbContext.SwSupportWorkerOtherQualifications.Where(x => x.SupportWorkerId == supportWorkerId);
            return SwSupportWorkerOtherQualifications;
        }
    }
}
