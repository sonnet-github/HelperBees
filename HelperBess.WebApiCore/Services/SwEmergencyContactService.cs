using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwEmergencyContactService : ISwEmergencyContactService
    {
        HelperBeesContext dbContext;
        public SwEmergencyContactService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwEmergencyContact AddSwEmergencyContact(SwEmergencyContact SwEmergencyContact)
        {
            if (SwEmergencyContact != null)
            {
                dbContext.SwEmergencyContacts.Add(SwEmergencyContact);
                dbContext.SaveChanges();
                return SwEmergencyContact;
            }
            return null;
        }

        public SwEmergencyContact DeleteSwEmergencyContact(int id)
        {
            var SwEmergencyContacts = dbContext.SwEmergencyContacts.FirstOrDefault(x => x.SwemergencyContactId == id);
            dbContext.Entry(SwEmergencyContacts).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwEmergencyContacts;
        }

        public IEnumerable<SwEmergencyContact> GetSwEmergencyContact()
        {
            var SwEmergencyContacts = dbContext.SwEmergencyContacts.ToList();
            return SwEmergencyContacts;
        }

        public SwEmergencyContact GetSwEmergencyContactById(int id)
        {
            var SwEmergencyContacts = dbContext.SwEmergencyContacts.FirstOrDefault(x => x.SwemergencyContactId == id);
            return SwEmergencyContacts;
        }

        public SwEmergencyContact UpdateSwEmergencyContact(SwEmergencyContact SwEmergencyContacts)
        {
            dbContext.Entry(SwEmergencyContacts).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwEmergencyContacts;
        }
    }
}
