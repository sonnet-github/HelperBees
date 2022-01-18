using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace HelperBess.WebApiCore.Services
{
    public class SwCoreExperienceFieldService : ISwCoreExperienceFieldService
    {
        HelperBeesContext dbContext;
        public SwCoreExperienceFieldService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwCoreExperienceField AddSwCoreExperienceField(SwCoreExperienceField SwCoreExperienceField)
        {
            if (SwCoreExperienceField != null)
            {
                dbContext.SwCoreExperienceFields.Add(SwCoreExperienceField);
                dbContext.SaveChanges();
                return SwCoreExperienceField;
            }
            return null;
        }

        public SwCoreExperienceField DeleteSwCoreExperienceField(int id)
        {
            var SwCoreExperienceFields = dbContext.SwCoreExperienceFields.FirstOrDefault(x => x.CoreExperienceFieldId == id);
            dbContext.Entry(SwCoreExperienceFields).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwCoreExperienceFields;
        }

        public IEnumerable<SwCoreExperienceField> GetSwCoreExperienceField()
        {
            var SwCoreExperienceFields = dbContext.SwCoreExperienceFields.ToList();
            return SwCoreExperienceFields;
        }

        public SwCoreExperienceField GetSwCoreExperienceFieldById(int id)
        {
            var SwCoreExperienceFields = dbContext.SwCoreExperienceFields.FirstOrDefault(x => x.CoreExperienceFieldId == id);
            return SwCoreExperienceFields;
        }

        public SwCoreExperienceField UpdateSwCoreExperienceField(SwCoreExperienceField SwCoreExperienceFields)
        {
            dbContext.Entry(SwCoreExperienceFields).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwCoreExperienceFields;
        }
    }
}
