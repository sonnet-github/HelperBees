using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwEducationService : ISwEducationService
    {
        HelperBeesContext dbContext;
        public SwEducationService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwEducation AddSwEducation(SwEducation SwEducation)
        {
            if (SwEducation != null)
            {
                dbContext.SwEducations.Add(SwEducation);
                dbContext.SaveChanges();
                return SwEducation;
            }
            return null;
        }

        public SwEducation DeleteSwEducation(int id)
        {
            var SwEducations = dbContext.SwEducations.FirstOrDefault(x => x.EducationId == id);
            dbContext.Entry(SwEducations).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwEducations;
        }

        public IEnumerable<SwEducation> GetSwEducation()
        {
            var SwEducations = dbContext.SwEducations.ToList();
            return SwEducations;
        }

        public SwEducation GetSwEducationById(int id)
        {
            var SwEducations = dbContext.SwEducations.FirstOrDefault(x => x.EducationId == id);
            return SwEducations;
        }

        public SwEducation UpdateSwEducation(SwEducation SwEducations)
        {
            dbContext.Entry(SwEducations).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwEducations;
        }
    }
}
