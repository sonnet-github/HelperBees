using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwWorkHistoryService : ISwWorkHistoryService
    {
        HelperBeesContext dbContext;
        public SwWorkHistoryService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwWorkHistory AddSwWorkHistory(SwWorkHistory SwWorkHistory)
        {
            if (SwWorkHistory != null)
            {
                dbContext.SwWorkHistories.Add(SwWorkHistory);
                dbContext.SaveChanges();
                return SwWorkHistory;
            }
            return null;
        }

        public SwWorkHistory DeleteSwWorkHistory(int id)
        {
            var SwWorkHistorys = dbContext.SwWorkHistories.FirstOrDefault(x => x.WorkHistoryId == id);
            dbContext.Entry(SwWorkHistorys).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwWorkHistorys;
        }

        public IEnumerable<SwWorkHistory> GetSwWorkHistory()
        {
            var SwWorkHistorys = dbContext.SwWorkHistories.ToList();
            return SwWorkHistorys;
        }

        public SwWorkHistory GetSwWorkHistoryById(int id)
        {
            var SwWorkHistorys = dbContext.SwWorkHistories.FirstOrDefault(x => x.WorkHistoryId == id);
            return SwWorkHistorys;
        }

        public IEnumerable<SwWorkHistory> GetSwWorkHistoryBySWId(int swid)
        {
            var SwWorkHistorys = dbContext.SwWorkHistories.Where(x => x.SupportWorkerId == swid);
            return SwWorkHistorys;
        }

        public SwWorkHistory UpdateSwWorkHistory(SwWorkHistory SwWorkHistorys)
        {
            dbContext.Entry(SwWorkHistorys).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwWorkHistorys;
        }
    }
}
