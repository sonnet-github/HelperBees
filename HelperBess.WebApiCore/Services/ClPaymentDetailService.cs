using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClPaymentDetailService : IClPaymentDetailService
    {
        HelperBeesContext dbContext;
        public ClPaymentDetailService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClPaymentDetail AddClPaymentDetail(ClPaymentDetail ClPaymentDetail)
        {
            if (ClPaymentDetail != null)
            {
                dbContext.ClPaymentDetails.Add(ClPaymentDetail);
                dbContext.SaveChanges();
                return ClPaymentDetail;
            }
            return null;
        }

        public ClPaymentDetail DeleteClPaymentDetail(int id)
        {
            var ClPaymentDetails = dbContext.ClPaymentDetails.FirstOrDefault(x => x.PaymentDetailsId == id);
            dbContext.Entry(ClPaymentDetails).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClPaymentDetails;
        }

        public IEnumerable<ClPaymentDetail> GetClPaymentDetail()
        {
            var ClPaymentDetails = dbContext.ClPaymentDetails.ToList();
            return ClPaymentDetails;
        }

        public ClPaymentDetail GetClPaymentDetailById(int id)
        {
            var ClPaymentDetails = dbContext.ClPaymentDetails.FirstOrDefault(x => x.PaymentDetailsId == id);
            return ClPaymentDetails;
        }

        public ClPaymentDetail UpdateClPaymentDetail(ClPaymentDetail ClPaymentDetails)
        {
            dbContext.Entry(ClPaymentDetails).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClPaymentDetails;
        }
    }
}
