using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerAhdetailService : ISwSupportWorkerAhdetailService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerAhdetailService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerAhdetail AddSwSupportWorkerAhdetail(SwSupportWorkerAhdetail SwSupportWorkerAhdetail)
        {
            if (SwSupportWorkerAhdetail != null)
            {
                dbContext.SwSupportWorkerAhdetails.Add(SwSupportWorkerAhdetail);
                dbContext.SaveChanges();
                return SwSupportWorkerAhdetail;
            }
            return null;
        }

        public SwSupportWorkerAhdetail DeleteSwSupportWorkerAhdetail(int id)
        {
            var SwSupportWorkerAhdetails = dbContext.SwSupportWorkerAhdetails.FirstOrDefault(x => x.SupportWorkerAhdetailsId == id);
            dbContext.Entry(SwSupportWorkerAhdetails).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerAhdetails;
        }

        public IEnumerable<SwSupportWorkerAhdetail> GetSwSupportWorkerAhdetail()
        {
            var SwSupportWorkerAhdetails = dbContext.SwSupportWorkerAhdetails.ToList();
            return SwSupportWorkerAhdetails;
        }

        public SwSupportWorkerAhdetail GetSwSupportWorkerAhdetailById(int id)
        {
            var SwSupportWorkerAhdetails = dbContext.SwSupportWorkerAhdetails.FirstOrDefault(x => x.SupportWorkerAhdetailsId == id);
            return SwSupportWorkerAhdetails;
        }

        public SwSupportWorkerAhdetail UpdateSwSupportWorkerAhdetail(SwSupportWorkerAhdetail SwSupportWorkerAhdetails)
        {
            dbContext.Entry(SwSupportWorkerAhdetails).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerAhdetails;
        }
    }
}
