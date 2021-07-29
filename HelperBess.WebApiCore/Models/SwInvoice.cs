using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwInvoice
    {
        public int InvoiceId { get; set; }
        public int? TimesheetId { get; set; }
        public DateTime? Datetime { get; set; }
        public int? InvoiceTemplateId { get; set; }
        public string InvoiceDetails { get; set; }

        public virtual SwInvoiceTemplate InvoiceTemplate { get; set; }
        public virtual SwTimesheet Timesheet { get; set; }
    }
}
