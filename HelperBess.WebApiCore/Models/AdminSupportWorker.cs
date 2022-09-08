﻿#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class AdminSupportWorker
    {
        public int AdminSupportWorkerId { get; set; }
        public int? AdministratorId { get; set; }
        public string Status { get; set; }
        public int? SupportWorkerId { get; set; }

        public virtual Administrator Admin { get; set; }
        public virtual SwSupportWorker SwSupportWorker { get; set; }
    }
}