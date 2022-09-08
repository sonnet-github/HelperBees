using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class AdminAccountHolderService : IAdminAccountHolderService
    {
        HelperBeesContext dbContext;
        public AdminAccountHolderService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public AdminAccountHolder AddAdminAccountHolder(AdminAccountHolder AdminAccountHolder)
        {
            if (AdminAccountHolder != null)
            {
                dbContext.AdminAccountHolders.Add(AdminAccountHolder);
                dbContext.SaveChanges();
                return AdminAccountHolder;
            }
            return null;
        }

        public AdminAccountHolder DeleteAdminAccountHolder(int id)
        {
            var AdminAccountHolders = dbContext.AdminAccountHolders.FirstOrDefault(x => x.AdminAccountHolderId == id);
            dbContext.Entry(AdminAccountHolders).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return AdminAccountHolders;
        }

        public IEnumerable<AdminAccountHolder> GetAdminAccountHolder()
        {
            var AdminAccountHolders = dbContext.AdminAccountHolders.ToList();
            return AdminAccountHolders;
        }

        public AdminAccountHolder GetAdminAccountHolderById(int id)
        {
            var AdminAccountHolders = dbContext.AdminAccountHolders.FirstOrDefault(x => x.AdminAccountHolderId == id);
            return AdminAccountHolders;
        }

        public AdminAccountHolder UpdateAdminAccountHolder(AdminAccountHolder AdminAccountHolders)
        {
            dbContext.Entry(AdminAccountHolders).State = EntityState.Modified;
            dbContext.SaveChanges();
            return AdminAccountHolders;
        }
    }
}
