/*  Problem 18. Extract e-mails

    Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

namespace ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class ExtractEmails
    {
        static void Main()
        {
            Console.Write("Enter your e-mail: ");
            string email = Console.ReadLine();

            string identifier = email.Substring(0, email.IndexOf('@'));

            int startIndexHost = email.IndexOf('@') + 1;
            int endIndexHost = email.LastIndexOf('.') - 1;

            string host = email.Substring(startIndexHost, endIndexHost - startIndexHost + 1);

            string domain = email.Substring(email.LastIndexOf('.') + 1);

            Console.WriteLine("Indentifier: " + identifier);
            Console.WriteLine("Host: " + host);
            Console.WriteLine("Domain: " + domain);
        }
    }
}
