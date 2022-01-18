using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerBankAccountService
    {
        IEnumerable<SwSupportWorkerBankAccount> GetSwSupportWorkerBankAccount();
        SwSupportWorkerBankAccount GetSwSupportWorkerBankAccountById(int id);
        SwSupportWorkerBankAccount AddSwSupportWorkerBankAccount(SwSupportWorkerBankAccount SwSupportWorkerBankAccount);
        SwSupportWorkerBankAccount UpdateSwSupportWorkerBankAccount(SwSupportWorkerBankAccount SwSupportWorkerBankAccount);
        SwSupportWorkerBankAccount DeleteSwSupportWorkerBankAccount(int id);
    }
}
