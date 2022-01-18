using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwQualificationService : ISwQualificationService
    {
        HelperBeesContext dbContext;
        public SwQualificationService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwQualification AddSwQualification(SwQualification SwQualification)
        {
            if (SwQualification != null)
            {
                dbContext.SwQualifications.Add(SwQualification);
                dbContext.SaveChanges();
                return SwQualification;
            }
            return null;
        }

        public SwQualification DeleteSwQualification(int id)
        {
            var SwQualifications = dbContext.SwQualifications.FirstOrDefault(x => x.QualificationId == id);
            dbContext.Entry(SwQualifications).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwQualifications;
        }

        public IEnumerable<SwQualification> GetSwQualification()
        {
            var SwQualifications = dbContext.SwQualifications.ToList();
            return SwQualifications;
        }

        public SwQualification GetSwQualificationById(int id)
        {
            var SwQualifications = dbContext.SwQualifications.FirstOrDefault(x => x.QualificationId == id);
            return SwQualifications;
        }

        public SwQualification UpdateSwQualification(SwQualification SwQualifications)
        {
            dbContext.Entry(SwQualifications).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwQualifications;
        }
    }
}
