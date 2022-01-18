using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class CulturalBackgroundService : ICulturalBackgroundService
    {
        HelperBeesContext dbContext;
        public CulturalBackgroundService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public CulturalBackground AddCulturalBackground(CulturalBackground CulturalBackground)
        {
            if (CulturalBackground != null)
            {
                dbContext.CulturalBackgrounds.Add(CulturalBackground);
                dbContext.SaveChanges();
                return CulturalBackground;
            }
            return null;
        }

        public CulturalBackground DeleteCulturalBackground(int id)
        {
            var CulturalBackgrounds = dbContext.CulturalBackgrounds.FirstOrDefault(x => x.CulturalBackgroundId == id);
            dbContext.Entry(CulturalBackgrounds).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return CulturalBackgrounds;
        }

        public IEnumerable<CulturalBackground> GetCulturalBackground()
        {
            var CulturalBackgrounds = dbContext.CulturalBackgrounds.ToList();
            return CulturalBackgrounds;
        }

        public CulturalBackground GetCulturalBackgroundById(int id)
        {
            var CulturalBackgrounds = dbContext.CulturalBackgrounds.FirstOrDefault(x => x.CulturalBackgroundId == id);
            return CulturalBackgrounds;
        }

        public CulturalBackground UpdateCulturalBackground(CulturalBackground CulturalBackgrounds)
        {
            dbContext.Entry(CulturalBackgrounds).State = EntityState.Modified;
            dbContext.SaveChanges();
            return CulturalBackgrounds;
        }
    }
}
