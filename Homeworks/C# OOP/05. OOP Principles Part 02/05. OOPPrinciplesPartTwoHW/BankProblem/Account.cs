using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankProblem
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal interestRate)
        {
            this.Customer = customer;
            this.InterestRate = interestRate;
            this.Balance = 0.0M;
        }

        public Customer Customer 
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance 
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        protected decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                this.interestRate = value;
            }
        }
        
        
        public void DepositMoney(decimal countMoney)
        {
            if (countMoney <= 0)
            {
                throw new ArgumentOutOfRangeException("Money have some value");
            }

            this.Balance += countMoney;
        }
        
        public virtual decimal CalculateInterestAmount(int numberOfMonths)
        {
            decimal interestAmount = this.interestRate * numberOfMonths;
            return interestAmount;
        }

    }
}
