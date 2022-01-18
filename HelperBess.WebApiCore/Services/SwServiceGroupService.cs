using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwServiceGroupService : ISwServiceGroupService
    {
        HelperBeesContext dbContext;
        public SwServiceGroupService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwServiceGroup AddSwServiceGroup(SwServiceGroup SwServiceGroup)
        {
            if (SwServiceGroup != null)
            {
                dbContext.SwServiceGroups.Add(SwServiceGroup);
                dbContext.SaveChanges();
                return SwServiceGroup;
            }
            return null;
        }

        public SwServiceGroup DeleteSwServiceGroup(int id)
        {
            var SwServiceGroups = dbContext.SwServiceGroups.FirstOrDefault(x => x.ServiceGroupId == id);
            dbContext.Entry(SwServiceGroups).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwServiceGroups;
        }

        public IEnumerable<SwServiceGroup> GetSwServiceGroup()
        {
            var SwServiceGroups = dbContext.SwServiceGroups.ToList();
            return SwServiceGroups;
        }

        public SwServiceGroup GetSwServiceGroupById(int id)
        {
            var SwServiceGroups = dbContext.SwServiceGroups.FirstOrDefault(x => x.ServiceGroupId == id);
            return SwServiceGroups;
        }

        public SwServiceGroup UpdateSwServiceGroup(SwServiceGroup SwServiceGroups)
        {
            dbContext.Entry(SwServiceGroups).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwServiceGroups;
        }
    }
}
