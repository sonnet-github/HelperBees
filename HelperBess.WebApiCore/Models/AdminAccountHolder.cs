﻿#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class AdminAccountHolder
    {
        public int AdminAccountHolderId { get; set; }
        public int? AdministratorId { get; set; }
        public string Status { get; set; }
        public int? AccountHolderId { get; set; }

        public virtual Administrator Admin { get; set; }
        //  public virtual SwSupportWorker SwSupportWorker { get; set; }
         public virtual ClAccountHolder ClAccountHolder { get; set; }
    }
}
