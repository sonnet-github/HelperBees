using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerRndetailService : ISwSupportWorkerRndetailService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerRndetailService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerRndetail AddSwSupportWorkerRndetail(SwSupportWorkerRndetail SwSupportWorkerRndetail)
        {
            if (SwSupportWorkerRndetail != null)
            {
                dbContext.SwSupportWorkerRndetails.Add(SwSupportWorkerRndetail);
                dbContext.SaveChanges();
                return SwSupportWorkerRndetail;
            }
            return null;
        }

        public SwSupportWorkerRndetail DeleteSwSupportWorkerRndetail(int id)
        {
            var SwSupportWorkerRndetails = dbContext.SwSupportWorkerRndetails.FirstOrDefault(x => x.SupportWorkerRndetailsId == id);
            dbContext.Entry(SwSupportWorkerRndetails).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerRndetails;
        }

        public IEnumerable<SwSupportWorkerRndetail> GetSwSupportWorkerRndetail()
        {
            var SwSupportWorkerRndetails = dbContext.SwSupportWorkerRndetails.ToList();
            return SwSupportWorkerRndetails;
        }

        public SwSupportWorkerRndetail GetSwSupportWorkerRndetailById(int id)
        {
            var SwSupportWorkerRndetails = dbContext.SwSupportWorkerRndetails.FirstOrDefault(x => x.SupportWorkerRndetailsId == id);
            return SwSupportWorkerRndetails;
        }

        public SwSupportWorkerRndetail UpdateSwSupportWorkerRndetail(SwSupportWorkerRndetail SwSupportWorkerRndetails)
        {
            dbContext.Entry(SwSupportWorkerRndetails).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerRndetails;
        }

        public IEnumerable<SwSupportWorkerRndetail> GetSwSupportWorkerRndetailBySupportWorkerId(int supportWorkerId)
        {
            var SwSupportWorkerRndetails = dbContext.SwSupportWorkerRndetails.Where(x => x.SupportWorkerId == supportWorkerId);
            return SwSupportWorkerRndetails;
        }
    }
}
