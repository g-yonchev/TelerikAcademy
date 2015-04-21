using System;

class Program
{
    static void Main()
    {
        string expresion = Console.ReadLine();

        decimal result = 0.0M;
        char currentOperator = '+';

        bool inBrackets = false;
        decimal resultInBrackets = 0;
        char currentBracketsOperator = '+';


        foreach (char symbol in expresion)
        {
            if (symbol == '(')
            {
                inBrackets = true;
                continue;
            }

            if (symbol == ')')
            {
                switch (currentOperator)
                    {
                        case '+': result = result + resultInBrackets; break;
                        case '-': result = result - resultInBrackets; break;
                        case '*': result = result * resultInBrackets; break;
                        case '/': result = result / resultInBrackets; break;
                    }
                resultInBrackets = 0;
                currentBracketsOperator = '+';
                inBrackets = false;
            }
            if (inBrackets)
            {
                
                
                if (symbol == '+' ||
                symbol == '-' ||
                symbol == '*' ||
                symbol == '/')
                {
                    currentBracketsOperator = symbol;
                }

                if (symbol >= '0' && symbol <= '9')
                {
                    string inString = Convert.ToString(symbol);
                    decimal digit = decimal.Parse(inString);
                    switch (currentBracketsOperator)
                    {
                        case '+': resultInBrackets = resultInBrackets + digit; break;
                        case '-': resultInBrackets = resultInBrackets - digit; break;
                        case '*': resultInBrackets = resultInBrackets * digit; break;
                        case '/': resultInBrackets = resultInBrackets / digit; break;
                    }
                }

            }
            else
            {
                if (symbol == '+' ||
                symbol == '-' ||
                symbol == '*' ||
                symbol == '/')
                {
                    currentOperator = symbol;
                }

                if (symbol >= '0' && symbol <= '9')
                {
                    string inString = Convert.ToString(symbol);
                    decimal digit = decimal.Parse(inString);
                    switch (currentOperator)
                    {
                        case '+': result = result + digit; break;
                        case '-': result = result - digit; break;
                        case '*': result = result * digit; break;
                        case '/': result = result / digit; break;
                    }
                }
            } 
        }
        Console.WriteLine("{0:F2}", result);
    }
}