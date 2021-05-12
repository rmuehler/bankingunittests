using System.Collections.Generic;
using System.Net;

namespace BankingService
{
    public class Bank
    {
        public List<Account> Accounts { get; set; }

        public Bank()
        {
            Accounts = new List<Account>() { };
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
    }
}