using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwTransportInfo
    {
        public int TransportInfoId { get; set; }
        public int? SupportWorkerId { get; set; }
        public string Dlnumber { get; set; }
        public string Dlstate { get; set; }
        public DateTime? DlexpiryDate { get; set; }
        public string Dlupload { get; set; }
        public string Mvtype { get; set; }
        public string MvlicencePlate { get; set; }
        public DateTime? MvregistrationExpiry { get; set; }
        public string MvregistrationUpload { get; set; }
        public string MvinsuranceType { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
