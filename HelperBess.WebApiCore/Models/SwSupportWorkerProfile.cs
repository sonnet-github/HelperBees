using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerProfile
    {
        public int SupportWorkerProfileId { get; set; }
        public int? SupportWorkerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? LegalName { get; set; }
        public string FriendlyName { get; set; }
        public string Bio { get; set; }
        public string CompanyPartnershipDetails { get; set; }
        public string CompanyName { get; set; }
        public string PartnershipName { get; set; }
        public int? InvoiceType { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
