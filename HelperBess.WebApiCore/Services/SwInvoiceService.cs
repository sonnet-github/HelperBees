using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwInvoiceService : ISwInvoiceService
    {
        HelperBeesContext dbContext;
        public SwInvoiceService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwInvoice AddSwInvoice(SwInvoice SwInvoice)
        {
            if (SwInvoice != null)
            {
                dbContext.SwInvoices.Add(SwInvoice);
                dbContext.SaveChanges();
                return SwInvoice;
            }
            return null;
        }

        public SwInvoice DeleteSwInvoice(int id)
        {
            var SwInvoices = dbContext.SwInvoices.FirstOrDefault(x => x.InvoiceId == id);
            dbContext.Entry(SwInvoices).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwInvoices;
        }

        public IEnumerable<SwInvoice> GetSwInvoice()
        {
            var SwInvoices = dbContext.SwInvoices.ToList();
            return SwInvoices;
        }

        public SwInvoice GetSwInvoiceById(int id)
        {
            var SwInvoices = dbContext.SwInvoices.FirstOrDefault(x => x.InvoiceId == id);
            return SwInvoices;
        }

        public SwInvoice UpdateSwInvoice(SwInvoice SwInvoices)
        {
            dbContext.Entry(SwInvoices).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwInvoices;
        }
    }
}
