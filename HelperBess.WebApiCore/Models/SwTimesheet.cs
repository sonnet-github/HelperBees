using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwTimesheet
    {
        public SwTimesheet()
        {
            SwInvoices = new HashSet<SwInvoice>();
            SwTimesheetIncidents = new HashSet<SwTimesheetIncident>();
        }

        public int TimesheetId { get; set; }
        public int? SupportWorkerId { get; set; }
        public int? JobId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? Rate { get; set; }
        public string ShiftNotes { get; set; }
        public bool? Incident { get; set; }
        public int? TimesheetStatusId { get; set; }
        public DateTime? PaymentReceived { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
        public virtual ICollection<SwInvoice> SwInvoices { get; set; }
        public virtual ICollection<SwTimesheetIncident> SwTimesheetIncidents { get; set; }
    }
}
