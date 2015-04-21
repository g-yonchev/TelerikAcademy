using System;

class PrintCompanyInformation
{
    static void Main()
    {
        /*  Problem 2. Print Company Information

            A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
            Write a program that reads the information about a company and its manager and prints it back on the console.
            Example input:

            program	            user
            Company name:	    Telerik Academy
            Company address:	31 Al. Malinov, Sofia
            Phone number:	    +359 888 55 55 555
            Fax number:	        2
            Web site:	        http://telerikacademy.com/
            Manager first name:	Nikolay
            Manager last name:	Kostov
            Manager age:	    25
            Manager phone:	    +359 2 981 981
            
            Example output:

            Telerik Academy
            Address: 231 Al. Malinov, Sofia
            Tel. +359 888 55 55 555
            Fax: (no fax)
            Web site: http://telerikacademy.com/
            Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)
        */

        Console.Title = "Company information";

        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter fax (0 for no fax): ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager second name: ");
        string managerSecondName = Console.ReadLine();
        Console.Write("Enter manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();

        if (faxNumber == "0")
        {
            faxNumber = "(no fax)";
        }

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel: {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerSecondName, managerAge, managerPhone);
    }
}