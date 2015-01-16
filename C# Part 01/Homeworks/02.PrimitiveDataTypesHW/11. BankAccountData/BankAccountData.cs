using System;

class BankAccountData
{
    static void Main()
    {
        /*  Problem 11. Bank Account Data

            A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
            Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
        */

        Console.Title = "Bank account data";

        string firstName = "Ivan";
        string middleName = "Georgiev";
        string lastName = "Petrov";
        object holderName = firstName + " " + middleName + " " + lastName;
        decimal accountBalance = 22034.12M;
        string bankName = "BNB";
        string iban = "BG00 BNBB 2200 3300 20A0 2766";
        ulong firstCardNumber = 6625225522779920u;
        ulong secondCardNumber = 6625225522779921u;
        ulong thirdCardNumber = 6625225522779922u;
        Console.WriteLine("Account holder: {0}", holderName);
        Console.WriteLine("Balance: {0:C}", accountBalance);
        Console.WriteLine("Bank: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit Cart N1: {0}", firstCardNumber);
        Console.WriteLine("Credit Cart N2: {0}", secondCardNumber);
        Console.WriteLine("Credit Cart N3: {0}", thirdCardNumber);
    }
}
