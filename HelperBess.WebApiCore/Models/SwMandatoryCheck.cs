using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwMandatoryCheck
    {
        public int MandatoryCheckId { get; set; }
        public int? SupportWorkerId { get; set; }
        public bool? Covid19training { get; set; }
        public string Covid19trainingDoc { get; set; }
        public DateTime? Covid19trainingDate { get; set; }
        public bool? PoliceCheck { get; set; }
        public string PoliceCheckDoc { get; set; }
        public DateTime? PoliceCheckDate { get; set; }
        public DateTime? PoliceCheckExpiry { get; set; }
        public bool? OsresCitizen { get; set; }
        public string OsresCitizenStatDec { get; set; }
        public bool? WorkingWithChildren { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
