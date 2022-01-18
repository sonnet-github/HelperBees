using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class ClHouseholdDetailService : IClHouseholdDetailService
    {
        HelperBeesContext dbContext;
        public ClHouseholdDetailService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public ClHouseholdDetail AddClHouseholdDetail(ClHouseholdDetail ClHouseholdDetail)
        {
            if (ClHouseholdDetail != null)
            {
                dbContext.ClHouseholdDetails.Add(ClHouseholdDetail);
                dbContext.SaveChanges();
                return ClHouseholdDetail;
            }
            return null;
        }

        public ClHouseholdDetail DeleteClHouseholdDetail(int id)
        {
            var ClHouseholdDetails = dbContext.ClHouseholdDetails.FirstOrDefault(x => x.HouseholdDetailsId == id);
            dbContext.Entry(ClHouseholdDetails).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return ClHouseholdDetails;
        }

        public IEnumerable<ClHouseholdDetail> GetClHouseholdDetail()
        {
            var ClHouseholdDetails = dbContext.ClHouseholdDetails.ToList();
            return ClHouseholdDetails;
        }

        public ClHouseholdDetail GetClHouseholdDetailById(int id)
        {
            var ClHouseholdDetails = dbContext.ClHouseholdDetails.FirstOrDefault(x => x.HouseholdDetailsId == id);
            return ClHouseholdDetails;
        }

        public ClHouseholdDetail UpdateClHouseholdDetail(ClHouseholdDetail ClHouseholdDetails)
        {
            dbContext.Entry(ClHouseholdDetails).State = EntityState.Modified;
            dbContext.SaveChanges();
            return ClHouseholdDetails;
        }
    }
}
