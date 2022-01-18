using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerPresignService : ISwSupportWorkerPresignService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerPresignService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerPresign AddSwSupportWorkerPresign(SwSupportWorkerPresign SwSupportWorkerPresign)
        {
            if (SwSupportWorkerPresign != null)
            {
                dbContext.SwSupportWorkerPresigns.Add(SwSupportWorkerPresign);
                dbContext.SaveChanges();
                return SwSupportWorkerPresign;
            }
            return null;
        }

        public SwSupportWorkerPresign DeleteSwSupportWorkerPresign(int id)
        {
            var SwSupportWorkerPresigns = dbContext.SwSupportWorkerPresigns.FirstOrDefault(x => x.SupportWorkerPresignId == id);
            dbContext.Entry(SwSupportWorkerPresigns).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerPresigns;
        }

        public IEnumerable<SwSupportWorkerPresign> GetSwSupportWorkerPresign()
        {
            var SwSupportWorkerPresigns = dbContext.SwSupportWorkerPresigns.ToList();
            return SwSupportWorkerPresigns;
        }

        public IEnumerable<SwSupportWorkerPresign> GetSwSupportWorkerPresignByLocation(string location)
        {
            var SwSupportWorkerPresigns = dbContext.SwSupportWorkerPresigns.Where(x => x.Location.Contains(location));
            return SwSupportWorkerPresigns;
        }

        public SwSupportWorkerPresign GetSwSupportWorkerPresignById(int id)
        {
            var SwSupportWorkerPresigns = dbContext.SwSupportWorkerPresigns.FirstOrDefault(x => x.SupportWorkerPresignId == id);
            return SwSupportWorkerPresigns;
        }

        public SwSupportWorkerPresign UpdateSwSupportWorkerPresign(SwSupportWorkerPresign SwSupportWorkerPresigns)
        {
            dbContext.Entry(SwSupportWorkerPresigns).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerPresigns;
        }
    }
}
