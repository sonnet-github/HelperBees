using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerCulturalBackgroundService : ISwSupportWorkerCulturalBackgroundService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerCulturalBackgroundService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerCulturalBackground AddSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground SwSupportWorkerCulturalBackground)
        {
            if (SwSupportWorkerCulturalBackground != null)
            {
                dbContext.SwSupportWorkerCulturalBackgrounds.Add(SwSupportWorkerCulturalBackground);
                dbContext.SaveChanges();
                return SwSupportWorkerCulturalBackground;
            }
            return null;
        }

        public SwSupportWorkerCulturalBackground DeleteSwSupportWorkerCulturalBackground(int id)
        {
            var SwSupportWorkerCulturalBackgrounds = dbContext.SwSupportWorkerCulturalBackgrounds.FirstOrDefault(x => x.SupportWorkerCulturalBackgroundId == id);
            dbContext.Entry(SwSupportWorkerCulturalBackgrounds).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerCulturalBackgrounds;
        }

        public IEnumerable<SwSupportWorkerCulturalBackground> GetSwSupportWorkerCulturalBackground()
        {
            var SwSupportWorkerCulturalBackgrounds = dbContext.SwSupportWorkerCulturalBackgrounds.ToList();
            return SwSupportWorkerCulturalBackgrounds;
        }

        public SwSupportWorkerCulturalBackground GetSwSupportWorkerCulturalBackgroundById(int id)
        {
            var SwSupportWorkerCulturalBackgrounds = dbContext.SwSupportWorkerCulturalBackgrounds.FirstOrDefault(x => x.SupportWorkerCulturalBackgroundId == id);
            return SwSupportWorkerCulturalBackgrounds;
        }

        public SwSupportWorkerCulturalBackground UpdateSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground SwSupportWorkerCulturalBackgrounds)
        {
            dbContext.Entry(SwSupportWorkerCulturalBackgrounds).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerCulturalBackgrounds;
        }

        public IEnumerable<SwSupportWorkerCulturalBackground> GetSwSupportWorkerCulturalBackgroundBySupportWorkerId(int supportWorkerId)
        {
            var SwSupportWorkerCulturalBackgrounds = dbContext.SwSupportWorkerCulturalBackgrounds.Where(x => x.SupportWorkerId == supportWorkerId);
            return SwSupportWorkerCulturalBackgrounds;
        }
    }
}
