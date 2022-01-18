#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwTimesheetIncident
    {
        public int IncidentId { get; set; }
        public int? TimesheetId { get; set; }
        public string IncidentDetails { get; set; }

        public virtual SwTimesheet Timesheet { get; set; }
    }
}
