/*  Problem 3. Read file contents

    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    Find in MSDN how to use System.IO.File.ReadAllText(…).
    Be sure to catch all possible exceptions and print user-friendly error messages.
*/

namespace ReadFileContents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    
    class ReadFileContents
    {
        static void Main()
        {
            Console.Write("Enter a path: ");
            string path = Console.ReadLine();

            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (ArgumentNullException argNullEx)
            {
                Console.WriteLine(argNullEx.Message);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            catch (PathTooLongException longPathEx)
            {
                Console.WriteLine(longPathEx.Message);
            }
            catch (DirectoryNotFoundException dnfEx)
            {
                Console.WriteLine(dnfEx.Message);
            }
            
            catch (UnauthorizedAccessException uaEx)
            {
                Console.WriteLine(uaEx.Message);
            }
            catch (FileNotFoundException fileNotFoundEx)
            {
                Console.WriteLine(fileNotFoundEx.Message);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
