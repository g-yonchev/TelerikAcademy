using System;

class EmployeeData
{
    static void Main()
    {
        /*  Problem 10. Employee Data

            A marketing company wants to keep record of its employees. Each record would have the following characteristics:

            First name
            Last name
            Age (0...100)
            Gender (m or f)
            Personal ID number (e.g. 8306112507)
            Unique employee number (27560000…27569999)
            Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
         */

        Console.Title = "Employee data";

        string firstNameOfEmployee = "Ivan";
        string lastNameOfEmployee = "Ivanov";
        byte ageOfEmployee = 30;
        char genderOfEmployee = 'm';
        ulong personalIdNumber = 8306112507;
        uint uniqueEmployeeNumber = 27569999;

        Console.WriteLine("First name: {0}", firstNameOfEmployee);
        Console.WriteLine("last name: {0}", lastNameOfEmployee);
        Console.WriteLine("Age: {0}", ageOfEmployee);
        Console.WriteLine("Gender: {0}", genderOfEmployee);
        Console.WriteLine("Personal ID number: {0}", personalIdNumber);
        Console.WriteLine("Unique employee number: {0}", uniqueEmployeeNumber);
    }
}
