using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClOtherContactService : IClOtherContactService
    {
        HelperBeesContext dbContext;
        public ClOtherContactService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClOtherContact AddClOtherContact(ClOtherContact ClOtherContact)
        {
            if (ClOtherContact != null)
            {
                dbContext.ClOtherContacts.Add(ClOtherContact);
                dbContext.SaveChanges();
                return ClOtherContact;
            }
            return null;
        }

        public ClOtherContact DeleteClOtherContact(int id)
        {
            var ClOtherContacts = dbContext.ClOtherContacts.FirstOrDefault(x => x.OtherContactId == id);
            dbContext.Entry(ClOtherContacts).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClOtherContacts;
        }

        public IEnumerable<ClOtherContact> GetClOtherContact()
        {
            var ClOtherContacts = dbContext.ClOtherContacts.ToList();
            return ClOtherContacts;
        }

        public ClOtherContact GetClOtherContactById(int id)
        {
            var ClOtherContacts = dbContext.ClOtherContacts.FirstOrDefault(x => x.OtherContactId == id);
            return ClOtherContacts;
        }

        public ClOtherContact UpdateClOtherContact(ClOtherContact ClOtherContacts)
        {
            dbContext.Entry(ClOtherContacts).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClOtherContacts;
        }
    }
}
