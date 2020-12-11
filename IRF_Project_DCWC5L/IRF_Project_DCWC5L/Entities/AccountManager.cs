using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_DCWC5L.Entities
{
    public class AccountManager : IAccountManager
    {
        public BindingList<Account> Accounts { get; } = new BindingList<Account>();

        public Account CreateAccount(Account account)
        {
            var oldAccount = (from a in Accounts
                              where a.Email.Equals(account.Email)
                              select a).FirstOrDefault();

            if (oldAccount != null)
                throw new ApplicationException(
                    "Már létezik felhasználó ilyen iTunes fiókkal!");

            Accounts.Add(account);

            return account;
        }
    }
}
