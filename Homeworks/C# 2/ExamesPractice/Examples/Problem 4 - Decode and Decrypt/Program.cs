using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();


        var builder = new StringBuilder();

        string number = "0";

        int index = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (!char.IsDigit(input[i]))
            {
                index = i + 1;
                break;
            }
        }

        for (int i = 0; i < index; i++)
        {
            if (char.IsDigit(input[i]))
            {
                number += input[i];
                continue;
            }
            if (number != "0")
            {
                builder.Append(input[i], int.Parse(number));
            }
            else
            {
                builder.Append(input[i]);
            }
            number = "0";
        }
        builder.Append(input.Substring(index));



        string newInput = builder.ToString();

        for (int i = newInput.Length - 1; i >= 0; i--)
        {
            if (!char.IsDigit(newInput[i]))
            {
                index = i + 1;
                break;
            }
        }
       
            
        int lentghChyper = int.Parse(newInput.Substring(index));


        string encrypedMsg = newInput.Substring(0, index - lentghChyper);

        string chyper = newInput.Substring(encrypedMsg.Length, lentghChyper);

        var result = new StringBuilder();

        if (encrypedMsg.Length >= chyper.Length)
        {
            int chyferLentCurrent = 0;
            for (int i = 0; i < encrypedMsg.Length; i++)
            {
                if (i == chyper.Length)
                {
                    chyferLentCurrent = 0;
                }
                int msgChar = encrypedMsg[i] - 'A';
                int chChar = chyper[chyferLentCurrent] - 'A';


                int charInt = (msgChar ^ chChar);
                char ch = (char)(charInt + 65);
                result.Append(ch);
                
                chyferLentCurrent++;
            }


        }
        else
        {
            int msgLentCurrent = 0;
            result.Append(encrypedMsg);
            for (int i = 0; i < chyper.Length; i++)
            {
                if (i == encrypedMsg.Length)
                {
                    msgLentCurrent = 0;
                }
                int msgChar = result[msgLentCurrent] - 'A';
                int chChar = chyper[i] - 'A';


                int charInt = (msgChar ^ chChar);
                char ch = (char)(charInt + 65);
                result.Remove(msgLentCurrent, 1);
                result.Insert(msgLentCurrent, ch);

                msgLentCurrent++;
            }

        }


        Console.WriteLine(result.ToString());
        



    }
}
