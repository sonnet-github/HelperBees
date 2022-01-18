using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwTransportInfoService : ISwTransportInfoService
    {
        HelperBeesContext dbContext;
        public SwTransportInfoService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwTransportInfo AddSwTransportInfo(SwTransportInfo SwTransportInfo)
        {
            if (SwTransportInfo != null)
            {
                dbContext.SwTransportInfos.Add(SwTransportInfo);
                dbContext.SaveChanges();
                return SwTransportInfo;
            }
            return null;
        }

        public SwTransportInfo DeleteSwTransportInfo(int id)
        {
            var SwTransportInfos = dbContext.SwTransportInfos.FirstOrDefault(x => x.TransportInfoId == id);
            dbContext.Entry(SwTransportInfos).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwTransportInfos;
        }

        public IEnumerable<SwTransportInfo> GetSwTransportInfo()
        {
            var SwTransportInfos = dbContext.SwTransportInfos.ToList();
            return SwTransportInfos;
        }

        public SwTransportInfo GetSwTransportInfoById(int id)
        {
            var SwTransportInfos = dbContext.SwTransportInfos.FirstOrDefault(x => x.TransportInfoId == id);
            return SwTransportInfos;
        }

        public SwTransportInfo UpdateSwTransportInfo(SwTransportInfo SwTransportInfos)
        {
            dbContext.Entry(SwTransportInfos).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwTransportInfos;
        }
    }
}
