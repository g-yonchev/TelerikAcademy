using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankProblem
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {

        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (base.Customer.GetType() == typeof(Company))
            {
                if (numberOfMonths <= 12)
                {
                    return (base.CalculateInterestAmount(numberOfMonths) / 2);
                }
                else
                {
                    return base.CalculateInterestAmount(numberOfMonths - 12);
                }
            }
            else
            {
                if (numberOfMonths <= 6)
                {
                    return 0.0M;
                }
                else
                {
                    return base.CalculateInterestAmount(numberOfMonths - 6);
                }
            }
            
        }
    }
}
