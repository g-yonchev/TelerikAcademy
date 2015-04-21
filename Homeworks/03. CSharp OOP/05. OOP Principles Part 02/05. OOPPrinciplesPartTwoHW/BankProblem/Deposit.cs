using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankProblem
{
    public class Deposit : Account, IDrawable
    {
        public Deposit(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {

        }

        public override decimal CalculateInterestAmount(int countMonths)
        {
            if (base.Balance > 0 && base.Balance < 1000)
            {
                return 0.0M;
            }

            return base.CalculateInterestAmount(countMonths);
        }

        public void DrawMoney(decimal countMoney)
        {
            if (countMoney <= 0)
            {
                throw new ArgumentOutOfRangeException("Money have some value");
            }

            base.Balance -= countMoney;
        }
    }
}
