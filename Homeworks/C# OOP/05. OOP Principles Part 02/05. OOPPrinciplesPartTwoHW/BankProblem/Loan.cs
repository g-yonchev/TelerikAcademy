using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankProblem
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {

        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (base.Customer.GetType() == typeof(Individual))
            {
                if (numberOfMonths <= 3)
                {
                    return 0.0M;
                }
                else
                {
                    return base.CalculateInterestAmount(numberOfMonths - 3);
                }
            }
            else
            {
                if (numberOfMonths <=2)
                {
                    return 0.0M;
                }
                else
                {
                    return base.CalculateInterestAmount(numberOfMonths - 2);
                }
            }
        }
    }
}
