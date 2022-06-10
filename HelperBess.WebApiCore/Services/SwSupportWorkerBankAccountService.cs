using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace HelperBess.WebApiCore.Services
{
    public class SwSupportWorkerBankAccountService : ISwSupportWorkerBankAccountService
    {
        HelperBeesContext dbContext;
        public SwSupportWorkerBankAccountService(HelperBeesContext _db)
        {
            dbContext = _db;
        }

        public SwSupportWorkerBankAccount AddSwSupportWorkerBankAccount(SwSupportWorkerBankAccount SwSupportWorkerBankAccount)
        {
            if (SwSupportWorkerBankAccount != null)
            {
                dbContext.SwSupportWorkerBankAccounts.Add(SwSupportWorkerBankAccount);
                dbContext.SaveChanges();
                return SwSupportWorkerBankAccount;
            }
            return null;
        }

        public SwSupportWorkerBankAccount DeleteSwSupportWorkerBankAccount(int id)
        {
            var SwSupportWorkerBankAccounts = dbContext.SwSupportWorkerBankAccounts.FirstOrDefault(x => x.BankAccountId == id);
            dbContext.Entry(SwSupportWorkerBankAccounts).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return SwSupportWorkerBankAccounts;
        }

        public IEnumerable<SwSupportWorkerBankAccount> GetSwSupportWorkerBankAccount()
        {
            var SwSupportWorkerBankAccounts = dbContext.SwSupportWorkerBankAccounts.ToList();
            return SwSupportWorkerBankAccounts;
        }

        public SwSupportWorkerBankAccount GetSwSupportWorkerBankAccountById(int id)
        {
            var SwSupportWorkerBankAccounts = dbContext.SwSupportWorkerBankAccounts.FirstOrDefault(x => x.BankAccountId == id);
            return SwSupportWorkerBankAccounts;
        }

        public SwSupportWorkerBankAccount UpdateSwSupportWorkerBankAccount(SwSupportWorkerBankAccount SwSupportWorkerBankAccounts)
        {
            dbContext.Entry(SwSupportWorkerBankAccounts).State = EntityState.Modified;
            dbContext.SaveChanges();
            return SwSupportWorkerBankAccounts;
        }

        public IEnumerable<SwSupportWorkerBankAccount> GetSwSupportWorkerBankAccountBySupportWorkerId(int supportWorkerId)
        {
            var SwSupportWorkerBankAccounts = dbContext.SwSupportWorkerBankAccounts.Where(x => x.SupportWorkerId == supportWorkerId);
            return SwSupportWorkerBankAccounts;
        }
    }
}
