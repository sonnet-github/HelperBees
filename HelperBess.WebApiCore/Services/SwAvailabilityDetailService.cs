using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwAvailabilityDetailService : ISwAvailabilityDetailService
    {
        HelperBeesContext dbContext;
        public SwAvailabilityDetailService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwAvailabilityDetail AddSwAvailabilityDetail(SwAvailabilityDetail SwAvailabilityDetail)
        {
            if (SwAvailabilityDetail != null)
            {
                dbContext.SwAvailabilityDetails.Add(SwAvailabilityDetail);
                dbContext.SaveChanges();
                return SwAvailabilityDetail;
            }
            return null;
        }

        public SwAvailabilityDetail DeleteSwAvailabilityDetail(int id)
        {
            var SwAvailabilityDetails = dbContext.SwAvailabilityDetails.FirstOrDefault(x => x.AvailabilityDetailsId == id);
            dbContext.Entry(SwAvailabilityDetails).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwAvailabilityDetails;
        }

        public IEnumerable<SwAvailabilityDetail> GetSwAvailabilityDetail()
        {
            var SwAvailabilityDetails = dbContext.SwAvailabilityDetails.ToList();
            return SwAvailabilityDetails;
        }

        public SwAvailabilityDetail GetSwAvailabilityDetailById(int id)
        {
            var SwAvailabilityDetails = dbContext.SwAvailabilityDetails.FirstOrDefault(x => x.AvailabilityDetailsId == id);
            return SwAvailabilityDetails;
        }

        public SwAvailabilityDetail UpdateSwAvailabilityDetail(SwAvailabilityDetail SwAvailabilityDetails)
        {
            dbContext.Entry(SwAvailabilityDetails).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwAvailabilityDetails;
        }


        public IEnumerable<SwAvailabilityDetail> GetSwAvailabilityDetailbySupportWorkerId(int supportWorkerId)
        {
            var SwSupportWorkerDetail = dbContext.SwAvailabilityDetails.Where(x => x.SupportWorkerId == supportWorkerId);
            return SwSupportWorkerDetail;
        }

        public IEnumerable<SwAvailabilityDetail> DeleteSwAvailabilityDetailbySupportWorkerId(int supportWorkerId)
        {
            var SwSupportWorkerDetail = dbContext.SwAvailabilityDetails.Where(x => x.SupportWorkerId == supportWorkerId).ToList();
            if (SwSupportWorkerDetail.Count > 0)
            {
                foreach (var n in SwSupportWorkerDetail)
                {
                    var SwSupportWorkerDetailx = dbContext.SwAvailabilityDetails.FirstOrDefault(x => x.AvailabilityDetailsId == n.AvailabilityDetailsId);
                    dbContext.Entry(SwSupportWorkerDetailx).State = EntityState.Deleted;
                    dbContext.SaveChanges();

                }
            }
            return SwSupportWorkerDetail;
        }


    }
}
