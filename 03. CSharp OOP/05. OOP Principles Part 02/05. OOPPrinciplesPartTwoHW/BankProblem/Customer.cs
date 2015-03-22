using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankProblem
{
    public abstract class Customer
    {
        private string name;
        private List<Account> accounts;

        public Customer(string name)
        {
            this.Name = name;
            this.accounts = new List<Account>();
        }

        public List<Account> Accounts
        {
            get
            {
                return new List<Account>(this.accounts);
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }
    }
}
