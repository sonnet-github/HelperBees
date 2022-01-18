using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwInvoiceService
    {
        IEnumerable<SwInvoice> GetSwInvoice();
        SwInvoice GetSwInvoiceById(int id);
        SwInvoice AddSwInvoice(SwInvoice SwInvoice);
        SwInvoice UpdateSwInvoice(SwInvoice SwInvoice);
        SwInvoice DeleteSwInvoice(int id);
    }
}
