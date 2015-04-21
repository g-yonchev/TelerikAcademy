﻿using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        /*  Problem 2. Gravitation on the Moon

            The gravitational field of the Moon is approximately 17% of that on the Earth.
            Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
            Examples:

            weight  weight on the Moon
            86      14.62
            74.6	12.682
            53.7	9.129
        */

        Console.Title = "Gravitation on the Moon";

        Console.Write("Enter your weight: ");
        double weight = double.Parse(Console.ReadLine());
        double percent = 0.17D;
        double newWeight = weight * percent;
        Console.WriteLine("Your weight on the Moon is: {0}", newWeight);

    }
}
