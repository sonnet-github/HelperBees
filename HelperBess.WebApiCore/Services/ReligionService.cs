using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ReligionService : IReligionService
    {
        HelperBeesContext dbContext;
        public ReligionService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public Religion AddReligion(Religion Religion)
        {
            if (Religion != null)
            {
                dbContext.Religions.Add(Religion);
                dbContext.SaveChanges();
                return Religion;
            }
            return null;
        }

        public Religion DeleteReligion(int id)
        {
            var Religions = dbContext.Religions.FirstOrDefault(x => x.ReligionId == id);
            dbContext.Entry(Religions).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return Religions;
        }

        public IEnumerable<Religion> GetReligion()
        {
            var Religions = dbContext.Religions.ToList();
            return Religions;
        }

        public Religion GetReligionById(int id)
        {
            var Religions = dbContext.Religions.FirstOrDefault(x => x.ReligionId == id);
            return Religions;
        }

        public Religion UpdateReligion(Religion Religions)
        {
            dbContext.Entry(Religions).State = EntityState.Modified;
            dbContext.SaveChanges();
            return Religions;
        }
    }
}
