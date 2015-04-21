using System;

class IntDoubleAndString
{
    static void Main()
    {
        /*  Problem 9. Play with Int, Double and String

            Write a program that, depending on the user’s choice, inputs an int, double or string variable.
            If the variable is int or double, the program increases it by one.
            If the variable is a string, the program appends * at the end.
            Print the result at the console. Use switch statement.
            
            Example 1:
            program	user
            Please choose a type:	
            1 --> int	
            2 --> double	3
            3 --> string	
            Please enter a string:	hello
            result: hello*	
         
            Example 2:
            program	user
            Please choose a type:	
            1 --> int	
            2 --> double	2
            3 --> string	
            Please enter a double:	1.5
            result: 2.5
         */

        Console.Title = "Int Double or String";
        start:
        Console.Write("Please choose a type (1 - int; 2 - double; 3 - string): ");
        int typeOfVariable = int.Parse(Console.ReadLine());

        if (typeOfVariable != 1 && typeOfVariable != 2 && typeOfVariable != 3)
        {
            Console.WriteLine("Wrong! Please, try again: ");
        }
        else if (typeOfVariable == 1)
        {
            Console.Write("Please enter an integer: ");
            int chosenInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Your result is: {0} + 1 = {1}", chosenInt, chosenInt + 1);
        }
        else if (typeOfVariable == 2)
        {
            Console.Write("Please enter a double: ");
            double chosenDouble = double.Parse(Console.ReadLine());
            Console.WriteLine("Your result is: {0:F2} + 1 = {1:F2}", chosenDouble, chosenDouble + 1);
        }
        else if (typeOfVariable == 3)
        {
            Console.Write("Please enter a string: ");
            string chosenString = Console.ReadLine();
            Console.WriteLine("Your result is: {0}*", chosenString);
        }
    }
}