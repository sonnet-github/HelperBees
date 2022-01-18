#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwSupportWorkerBankAccount
    {
        public int BankAccountId { get; set; }
        public int? SupportWorkerId { get; set; }
        public string Dlnumber { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public int? Bsb { get; set; }
        public int? AccountNumber { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
