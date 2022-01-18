using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelperBess.WebApiCore.Services
{
    public class SwInvoiceTemplateService : ISwInvoiceTemplateService
    {
        HelperBeesContext dbContext;
        public SwInvoiceTemplateService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwInvoiceTemplate AddSwInvoiceTemplate(SwInvoiceTemplate SwInvoiceTemplate)
        {
            if (SwInvoiceTemplate != null)
            {
                dbContext.SwInvoiceTemplates.Add(SwInvoiceTemplate);
                dbContext.SaveChanges();
                return SwInvoiceTemplate;
            }
            return null;
        }

        public SwInvoiceTemplate DeleteSwInvoiceTemplate(int id)
        {
            var SwInvoiceTemplates = dbContext.SwInvoiceTemplates.FirstOrDefault(x => x.InvoiceTemplateId == id);
            dbContext.Entry(SwInvoiceTemplates).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwInvoiceTemplates;
        }

        public IEnumerable<SwInvoiceTemplate> GetSwInvoiceTemplate()
        {
            var SwInvoiceTemplates = dbContext.SwInvoiceTemplates.ToList();
            return SwInvoiceTemplates;
        }

        public SwInvoiceTemplate GetSwInvoiceTemplateById(int id)
        {
            var SwInvoiceTemplates = dbContext.SwInvoiceTemplates.FirstOrDefault(x => x.InvoiceTemplateId == id);
            return SwInvoiceTemplates;
        }

        public SwInvoiceTemplate UpdateSwInvoiceTemplate(SwInvoiceTemplate SwInvoiceTemplates)
        {
            dbContext.Entry(SwInvoiceTemplates).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwInvoiceTemplates;
        }
    }
}
