using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwInvoiceTemplateService
    {
        IEnumerable<SwInvoiceTemplate> GetSwInvoiceTemplate();
        SwInvoiceTemplate GetSwInvoiceTemplateById(int id);
        SwInvoiceTemplate AddSwInvoiceTemplate(SwInvoiceTemplate SwInvoiceTemplate);
        SwInvoiceTemplate UpdateSwInvoiceTemplate(SwInvoiceTemplate SwInvoiceTemplate);
        SwInvoiceTemplate DeleteSwInvoiceTemplate(int id);
    }
}
