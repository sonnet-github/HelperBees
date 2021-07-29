using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClAccountHolderService : IClAccountHolderService
    {
        HelperBeesContext dbContext;
        public ClAccountHolderService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClAccountHolder AddClAccountHolder(ClAccountHolder clAccountHolder)
        {
            if (clAccountHolder != null)
            {
                dbContext.ClAccountHolders.Add(clAccountHolder);
                dbContext.SaveChanges();
                return clAccountHolder;
            }
            return null;
        }

        public ClAccountHolder DeleteClAccountHolder(int id)
        {
            var clAccountHolders = dbContext.ClAccountHolders.FirstOrDefault(x => x.AccountHolderId == id);
            dbContext.Entry(clAccountHolders).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return clAccountHolders;
        }

        public IEnumerable<ClAccountHolder> GetClAccountHolder()
        {
            var clAccountHolders = dbContext.ClAccountHolders.ToList();
            return clAccountHolders;
        }

        public ClAccountHolder GetClAccountHolderById(int id)
        {
            var clAccountHolders = dbContext.ClAccountHolders.FirstOrDefault(x => x.AccountHolderId == id);
            return clAccountHolders;
        }

        public ClAccountHolder UpdateClAccountHolder(ClAccountHolder clAccountHolder)
        {
            dbContext.Entry(clAccountHolder).State = EntityState.Modified;
            dbContext.SaveChanges();
            return clAccountHolder;
        }
    }
}
