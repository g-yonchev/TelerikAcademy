/*  Problem 5. Parse tags

    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.
    Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

    The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

namespace ParseTags
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class ParseTags
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            string openingTag = "<upcase>";
            string closingTag = "</upcase>";

            int startIndex = text.IndexOf(openingTag) + openingTag.Length;
            int endIndex = text.IndexOf(closingTag);

            while (endIndex != -1)
            {
                string lower = text.Substring(startIndex, endIndex - startIndex);
                string upper = lower.ToUpper();

                text = text.Replace(openingTag + lower + closingTag, upper);
                
                startIndex = text.IndexOf(openingTag) + openingTag.Length;
                endIndex = text.IndexOf(closingTag);
            }

            Console.WriteLine(text);
        }
    }
}
