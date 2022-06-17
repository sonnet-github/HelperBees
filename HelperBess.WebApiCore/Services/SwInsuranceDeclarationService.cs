using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwInsuranceDeclarationService : ISwInsuranceDeclarationService
    {
        HelperBeesContext dbContext;
        public SwInsuranceDeclarationService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwInsuranceDeclaration AddSwInsuranceDeclaration(SwInsuranceDeclaration SwInsuranceDeclaration)
        {
            if (SwInsuranceDeclaration != null)
            {
                dbContext.SwInsuranceDeclarations.Add(SwInsuranceDeclaration);
                dbContext.SaveChanges();
                return SwInsuranceDeclaration;
            }
            return null;
        }

        public SwInsuranceDeclaration DeleteSwInsuranceDeclaration(int id)
        {
            var SwInsuranceDeclarations = dbContext.SwInsuranceDeclarations.FirstOrDefault(x => x.InsuranceDeclarationId == id);
            dbContext.Entry(SwInsuranceDeclarations).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwInsuranceDeclarations;
        }

        public IEnumerable<SwInsuranceDeclaration> GetSwInsuranceDeclaration()
        {
            var SwInsuranceDeclarations = dbContext.SwInsuranceDeclarations.ToList();
            return SwInsuranceDeclarations;
        }

        public SwInsuranceDeclaration GetSwInsuranceDeclarationById(int id)
        {
            var SwInsuranceDeclarations = dbContext.SwInsuranceDeclarations.FirstOrDefault(x => x.InsuranceDeclarationId == id);
            return SwInsuranceDeclarations;
        }

        public IEnumerable<SwInsuranceDeclaration> GetSwInsuranceDeclarationBySWId(int swid)
        {
            var SwInsuranceDeclarations = dbContext.SwInsuranceDeclarations.Where(x => x.SupportWorkerId == swid);
            return SwInsuranceDeclarations;
        }

        public SwInsuranceDeclaration UpdateSwInsuranceDeclaration(SwInsuranceDeclaration SwInsuranceDeclarations)
        {
            dbContext.Entry(SwInsuranceDeclarations).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwInsuranceDeclarations;
        }
    }
}
