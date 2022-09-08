using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class AdministratorService : IAdministratorService
    {
        HelperBeesContext dbContext;
        public AdministratorService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public Administrator AddAdministrator(Administrator Administrator)
        {
            if (Administrator != null)
            {
                dbContext.Administrator.Add(Administrator);
                dbContext.SaveChanges();
                return Administrator;
            }
            return null;
        }

        public Administrator DeleteAdministrator(int id)
        {
            var Administrators = dbContext.Administrator.FirstOrDefault(x => x.AdministratorId == id);
            dbContext.Entry(Administrators).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return Administrators;
        }

        public IEnumerable<Administrator> GetAdministrator()
        {
            var Administrators = dbContext.Administrator.ToList();
            return Administrators;
        }

        public Administrator GetAdministratorById(int id)
        {
            var Administrators = dbContext.Administrator.FirstOrDefault(x => x.AdministratorId == id);
            return Administrators;
        }

        public Administrator GetAdministratorByEmail(string EmailAddress)
        {
            var Administrators = dbContext.Administrator.FirstOrDefault(x => x.EmailAddress == EmailAddress);
            return Administrators;
        }


        public Administrator UpdateAdministrator(Administrator Administrators)
        {
            dbContext.Entry(Administrators).State = EntityState.Modified;
            dbContext.SaveChanges();
            return Administrators;
        }
    }
}
