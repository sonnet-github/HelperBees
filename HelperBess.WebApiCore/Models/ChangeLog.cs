using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ChangeLog
    {
        public int ChangeLogId { get; set; }
        public int SupportWorkerId { get; set; }
        public DateTime? DateTime { get; set; }
        public string TableChanged { get; set; }
        public string FieldChanged { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
