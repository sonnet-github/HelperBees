using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace HelperBess.WebApiCore.Services
{
    public class SwClientService : ISwClientService
    {
        HelperBeesContext dbContext;
        public SwClientService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwClient AddSwClient(SwClient SwClient)
        {
            if (SwClient != null)
            {
                dbContext.SwClients.Add(SwClient);
                dbContext.SaveChanges();
                return SwClient;
            }
            return null;
        }

        public SwClient DeleteSwClient(int id)
        {
            var SwClients = dbContext.SwClients.FirstOrDefault(x => x.ClientId == id);
            dbContext.Entry(SwClients).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwClients;
        }

        public IEnumerable<SwClient> GetSwClient()
        {
            var SwClients = dbContext.SwClients.ToList();
            return SwClients;
        }

        public SwClient GetSwClientById(int id)
        {
            var SwClients = dbContext.SwClients.FirstOrDefault(x => x.ClientId == id);
            return SwClients;
        }

        public IEnumerable<SwClient> GetSwClientBySupportWorkerId(int supportWorkerId)
        {
            var SwClients = dbContext.SwClients.Where(x => x.SupportWorkerId == supportWorkerId);
            return SwClients;
        }

        public IEnumerable<SwClient> GetSwClientByParticipantId(int ParticpantId)
        {
            var SwClients = dbContext.SwClients.Where(x => x.ParticpantId == ParticpantId);
            return SwClients;
        }


        public SwClient UpdateSwClient(SwClient SwClients)
        {
            dbContext.Entry(SwClients).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwClients;
        }
    }
}
