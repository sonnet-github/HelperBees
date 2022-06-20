using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwReferenceService : ISwReferenceService
    {
        HelperBeesContext dbContext;
        public SwReferenceService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwReference AddSwReference(SwReference SwReference)
        {
            if (SwReference != null)
            {
                dbContext.SwReferences.Add(SwReference);
                dbContext.SaveChanges();
                return SwReference;
            }
            return null;
        }

        public SwReference DeleteSwReference(int id)
        {
            var SwReferences = dbContext.SwReferences.FirstOrDefault(x => x.ReferenceId == id);
            dbContext.Entry(SwReferences).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwReferences;
        }

        public IEnumerable<SwReference> GetSwReference()
        {
            var SwReferences = dbContext.SwReferences.ToList();
            return SwReferences;
        }

        public SwReference GetSwReferenceById(int id)
        {
            var SwReferences = dbContext.SwReferences.FirstOrDefault(x => x.ReferenceId == id);
            return SwReferences;
        }

        public IEnumerable<SwReference> GetSwReferenceBySWId(int swid)
        {
            var SwReferences = dbContext.SwReferences.Where(x => x.SupportWorkerId == swid);
            return SwReferences;
        }

        public SwReference UpdateSwReference(SwReference SwReferences)
        {
            dbContext.Entry(SwReferences).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwReferences;
        }
    }
}
