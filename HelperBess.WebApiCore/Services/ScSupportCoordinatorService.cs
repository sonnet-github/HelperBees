using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ScSupportCoordinatorService : IScSupportCoordinatorService
    {
        HelperBeesContext dbContext;
        public ScSupportCoordinatorService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ScSupportCoordinator AddScSupportCoordinator(ScSupportCoordinator ScSupportCoordinator)
        {
            if (ScSupportCoordinator != null)
            {
                dbContext.ScSupportCoordinators.Add(ScSupportCoordinator);
                dbContext.SaveChanges();
                return ScSupportCoordinator;
            }
            return null;
        }

        public ScSupportCoordinator DeleteScSupportCoordinator(int id)
        {
            var ScSupportCoordinators = dbContext.ScSupportCoordinators.FirstOrDefault(x => x.SupportCoordinatorId == id);
            dbContext.Entry(ScSupportCoordinators).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ScSupportCoordinators;
        }

        public IEnumerable<ScSupportCoordinator> GetScSupportCoordinator()
        {
            var ScSupportCoordinators = dbContext.ScSupportCoordinators.ToList();
            return ScSupportCoordinators;
        }

        public ScSupportCoordinator GetScSupportCoordinatorById(int id)
        {
            var ScSupportCoordinators = dbContext.ScSupportCoordinators.FirstOrDefault(x => x.SupportCoordinatorId == id);
            return ScSupportCoordinators;
        }

        public ScSupportCoordinator GetScSupportCoordinatorByEmail(string emailaddress)
        {
            var ScSupportCoordinators = dbContext.ScSupportCoordinators.FirstOrDefault(x => x.EmailAddress == emailaddress);
            return ScSupportCoordinators;
        }

        public ScSupportCoordinator UpdateScSupportCoordinator(ScSupportCoordinator ScSupportCoordinators)
        {
            dbContext.Entry(ScSupportCoordinators).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ScSupportCoordinators;
        }
    }
}
