using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwInvoiceTemplate
    {
        public SwInvoiceTemplate()
        {
            SwInvoices = new HashSet<SwInvoice>();
        }

        public int InvoiceTemplateId { get; set; }
        public string TemplateName { get; set; }

        public virtual ICollection<SwInvoice> SwInvoices { get; set; }
    }
}
