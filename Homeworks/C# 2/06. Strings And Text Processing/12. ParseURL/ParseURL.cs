/*  Problem 12. Parse URL

    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
    Example:

    URL	                                                            Information
    http://telerikacademy.com/Courses/Courses/Details/212	        [protocol] = http 
                                                                    [server] = telerikacademy.com 
                                                                    [resource] = /Courses/Courses/Details/212
*/

namespace ParseURL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class ParseURL
    {
        static void Main()
        {
            Console.WriteLine("Enter URL address:");
            string url = Console.ReadLine();

            int indexOfProtocol = url.IndexOf("://");
            string protocol = url.Substring(0, indexOfProtocol);
            
            int startIndexOfServer = protocol.Length + 3;
            int endIndexOfServer = url.IndexOf("/",startIndexOfServer);
            string server = url.Substring(startIndexOfServer, endIndexOfServer - startIndexOfServer);
            string resource = url.Substring(endIndexOfServer);

            Console.WriteLine("[protocol] = " + protocol);
            Console.WriteLine("[server] = " + server);
            Console.WriteLine("[resource] = " + resource);
        }
    }
}
