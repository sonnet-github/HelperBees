using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerPcdetailService : ISwSupportWorkerPcdetailService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerPcdetailService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerPcdetail AddSwSupportWorkerPcdetail(SwSupportWorkerPcdetail SwSupportWorkerPcdetail)
        {
            if (SwSupportWorkerPcdetail != null)
            {
                dbContext.SwSupportWorkerPcdetails.Add(SwSupportWorkerPcdetail);
                dbContext.SaveChanges();
                return SwSupportWorkerPcdetail;
            }
            return null;
        }

        public SwSupportWorkerPcdetail DeleteSwSupportWorkerPcdetail(int id)
        {
            var SwSupportWorkerPcdetails = dbContext.SwSupportWorkerPcdetails.FirstOrDefault(x => x.SupportWorkerPcdetailsId == id);
            dbContext.Entry(SwSupportWorkerPcdetails).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerPcdetails;
        }

        public IEnumerable<SwSupportWorkerPcdetail> GetSwSupportWorkerPcdetail()
        {
            var SwSupportWorkerPcdetails = dbContext.SwSupportWorkerPcdetails.ToList();
            return SwSupportWorkerPcdetails;
        }

        public SwSupportWorkerPcdetail GetSwSupportWorkerPcdetailById(int id)
        {
            var SwSupportWorkerPcdetails = dbContext.SwSupportWorkerPcdetails.FirstOrDefault(x => x.SupportWorkerPcdetailsId == id);
            return SwSupportWorkerPcdetails;
        }

        public SwSupportWorkerPcdetail UpdateSwSupportWorkerPcdetail(SwSupportWorkerPcdetail SwSupportWorkerPcdetails)
        {
            dbContext.Entry(SwSupportWorkerPcdetails).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerPcdetails;
        }

        public IEnumerable<SwSupportWorkerPcdetail> GetSwSupportWorkerPcdetailBySupportWorkerId(int supportWorkerId)
        {
            var SwSupportWorkerPcdetails = dbContext.SwSupportWorkerPcdetails.Where(x => x.SupportWorkerId == supportWorkerId);
            return SwSupportWorkerPcdetails;
        }
    }
}
