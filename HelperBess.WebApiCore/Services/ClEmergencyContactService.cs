using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClEmergencyContactService: IClEmergencyContactService
    {
        HelperBeesContext dbContext;
        public ClEmergencyContactService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClEmergencyContact AddClEmergencyContact(ClEmergencyContact ClEmergencyContact)
        {
            if (ClEmergencyContact != null)
            {
                dbContext.ClEmergencyContacts.Add(ClEmergencyContact);
                dbContext.SaveChanges();
                return ClEmergencyContact;
            }
            return null;
        }

        public ClEmergencyContact DeleteClEmergencyContact(int id)
        {
            var clEmergencyContact = dbContext.ClEmergencyContacts.FirstOrDefault(x => x.EmergencyContactId == id);
            dbContext.Entry(clEmergencyContact).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return clEmergencyContact;
        }

        public IEnumerable<ClEmergencyContact> GetClEmergencyContact()
        {
            var clEmergencyContact = dbContext.ClEmergencyContacts.ToList();
            return clEmergencyContact;
        }

        public ClEmergencyContact GetClEmergencyContactById(int id)
        {
            var clEmergencyContact = dbContext.ClEmergencyContacts.FirstOrDefault(x => x.EmergencyContactId == id);
            return clEmergencyContact;
        }

        public ClEmergencyContact UpdateClEmergencyContact(ClEmergencyContact clEmergencyContact)
        {
            dbContext.Entry(clEmergencyContact).State = EntityState.Modified;
            dbContext.SaveChanges();
            return clEmergencyContact;
        }

    }
}
