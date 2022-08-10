using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class Status
    {
        public Status()
        {
            ClAccountHolders = new HashSet<ClAccountHolder>();
            SwSupportWorkers = new HashSet<SwSupportWorker>();
            Administrators = new HashSet<Administrator>();
        }

        public int StatusId { get; set; }
        public string Status1 { get; set; }

        public virtual ICollection<ClAccountHolder> ClAccountHolders { get; set; }
        public virtual ICollection<SwSupportWorker> SwSupportWorkers { get; set; }

        public virtual ICollection<Administrator> Administrators { get; set; }

    }
}
