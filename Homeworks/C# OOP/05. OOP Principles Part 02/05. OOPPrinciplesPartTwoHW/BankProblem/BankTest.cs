/*  Problem 2. Bank accounts

    A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
    All accounts have customer, balance and interest rate (monthly based).
    Deposit accounts are allowed to deposit and with draw money.
    Loan and mortgage accounts can only deposit money.
    All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
    Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
    Deposit accounts have no interest if their balance is positive and less than 1000.
    Mortgage accounts have 1/2 interest for the first 12 months for companies and no interest for the first 6 months for individuals.
    Your task is to write a program to model the bank system by classes and interfaces.
    You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
*/

namespace BankProblem
{
    class BankTest
    {
        static void Main()
        {
            Customer pesho = new Individual("Pesho");
            Customer firmataNaPesho = new Company("Pesho Inc");

            Account loan1 = new Loan(pesho,12.2M);
            Account loan2 = new Loan(firmataNaPesho, 12.2M);

            loan1.DepositMoney(1000M);
            loan2.DepositMoney(1000M);

            System.Console.WriteLine(string.Format("Loan {0}. Interest amount: {1:C}", loan1.Customer.Name, loan1.CalculateInterestAmount(24)));
            System.Console.WriteLine(string.Format("Loan {0}. Interest amount: {1:C}", loan2.Customer.Name, loan2.CalculateInterestAmount(24)));

            Account deposit1 = new Deposit(pesho, 13M);
            Account deposit2 = new Deposit(firmataNaPesho, 13M);

            deposit1.DepositMoney(15M);
            deposit2.DepositMoney(2000M);

            System.Console.WriteLine(string.Format(
                "Deposit {0}. Interest amount: {1:C}", deposit1.Customer.Name, deposit1.CalculateInterestAmount(24)));
            System.Console.WriteLine(string.Format(
                "Deposit {0}. Interest amount: {1:C}", deposit2.Customer.Name, deposit2.CalculateInterestAmount(24)));


            Account mortage1 = new Mortgage(pesho, 10.2M);
            Account mortage2 = new Mortgage(firmataNaPesho , 10.2M);

            mortage1.DepositMoney(200M);
            mortage2.DepositMoney(200M);

            System.Console.WriteLine(string.Format(
                "Mortage {0}. Interest amount: {1:C}", mortage1.Customer.Name, mortage1.CalculateInterestAmount(24)));
            System.Console.WriteLine(string.Format(
                "Mortage {0}. Interest amount: {1:C}", mortage2.Customer.Name, mortage2.CalculateInterestAmount(24)));
        }
    }
}
