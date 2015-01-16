using System;

class IsoscelesTriangle
{
    static void Main()
    {
        /*  Problem 8. Isosceles Triangle

            Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
               ©

              © ©

             ©   ©

            © © © ©
        */

        Console.Title = "Triangle";

        char symbol = '\u00A9'; // ©
        Console.WriteLine(@"Triangle:
            {0}

           {0} {0}

          {0}   {0}

         {0} {0} {0} {0}", symbol);
    }
}