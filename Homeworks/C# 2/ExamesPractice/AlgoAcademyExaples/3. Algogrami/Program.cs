using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static bool AreAnagram(string s1, string s2)
    {

        if (s1.Length != s2.Length)
            return false;

        foreach (char c in s1)
        {
            int ix = s2.IndexOf(c);

            if (ix == -1)
                return false;
        }

        return true;
    }
    
    static void Main()
    {
        var words = new List<string>();

        string line = Console.ReadLine();

        while (line != "-1")
        {
            words.Add(line);
            line = Console.ReadLine();
        }

        string[] wordsArray = new string[words.Count];
        for (int i = 0; i < words.Count; i++)
        {
            wordsArray[i] = words[i];
        }

        bool[] groupAnagrams = new bool[words.Count];
        int couterForGroups = 0;

        for (int i = 0; i < words.Count; i++)
        {
            string currentWord = words[i];

            bool anagram;
            
            for (int j = 0; j < words.Count; j++)
			{
                anagram = AreAnagram(currentWord, words[j]);
                if (anagram)
                {
                    groupAnagrams[couterForGroups] = true;
                    if (i != j)
                    {
                        words.RemoveAt(j);
                        j--;
                    }
                } 
			}
            couterForGroups++;
        }

        int counter = 0;
        for (int i = 0; i < groupAnagrams.Length; i++)
        {
            if (groupAnagrams[i] == true)
            {
                counter++;
            }
        }
            Console.WriteLine(counter);
    }
}