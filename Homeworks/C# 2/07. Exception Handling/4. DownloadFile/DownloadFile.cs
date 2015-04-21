﻿/*  Problem 4. Download file

    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    Find in Google how to download files in C#.
    Be sure to catch all exceptions and to free any used resources in the finally block.
*/

namespace DownloadFile
{
    using System;
    using System.Net;
    
    class DownloadFile
    {
        static void Main()
        {
            using (WebClient downloadClient = new WebClient())
            {
                try
                {
                    downloadClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
                    Console.WriteLine("Image was downloaded successfully in 'bin' directory of the project!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
