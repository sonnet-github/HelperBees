using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerReligionService : ISwSupportWorkerReligionService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerReligionService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerReligion AddSwSupportWorkerReligion(SwSupportWorkerReligion SwSupportWorkerReligion)
        {
            if (SwSupportWorkerReligion != null)
            {
                dbContext.SwSupportWorkerReligions.Add(SwSupportWorkerReligion);
                dbContext.SaveChanges();
                return SwSupportWorkerReligion;
            }
            return null;
        }

        public SwSupportWorkerReligion DeleteSwSupportWorkerReligion(int id)
        {
            var SwSupportWorkerReligions = dbContext.SwSupportWorkerReligions.FirstOrDefault(x => x.SupportWorkerReligionId == id);
            dbContext.Entry(SwSupportWorkerReligions).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerReligions;
        }

        public IEnumerable<SwSupportWorkerReligion> GetSwSupportWorkerReligion()
        {
            var SwSupportWorkerReligions = dbContext.SwSupportWorkerReligions.ToList();
            return SwSupportWorkerReligions;
        }

        public SwSupportWorkerReligion GetSwSupportWorkerReligionById(int id)
        {
            var SwSupportWorkerReligions = dbContext.SwSupportWorkerReligions.FirstOrDefault(x => x.SupportWorkerReligionId == id);
            return SwSupportWorkerReligions;
        }

        public SwSupportWorkerReligion UpdateSwSupportWorkerReligion(SwSupportWorkerReligion SwSupportWorkerReligions)
        {
            dbContext.Entry(SwSupportWorkerReligions).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerReligions;
        }
    }
}
