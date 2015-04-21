/*  Problem 1. School classes

    We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
    Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
*/

namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class SchoolTest
    {
        static void Main()
        {
            School mySchool = new School("Telerik Academy");

            // Creating students
            Student[] studentsFirstGroup = new Student[]
            {
                new Student("Georgi Yonchev", 2342032),
                new Student("Stamat Stamatov", 3023224),
                new Student("Pesho Ivanov", 3023434),
                new Student("Georgi Ivanov", 2223434),
                new Student("Mariya Ivanova", 4566434),
                new Student("Pesho Todorov", 2000032)
            };

            Student[] studentsSecondGroup = new Student[]
            {
                new Student("Georgi Petrov", 1342032),
                new Student("Albenoa Kalinova", 2333224),
                new Student("Zahari Zahariev", 3023555),
                new Student("Hristo Georgiev", 2234554),
                new Student("Nikoleta Zlatkova", 7765004),
                new Student("Nikoleta Chaneva", 3023100)
            };
            
            // Creating disciplines
            Discipline cSharp = new Discipline("C Sharp Fundamentals", 30, 30);
            Discipline javaScript = new Discipline("JavaScript Fundamentals", 40, 50);
            Discipline html = new Discipline("HTML5", 12, 13);
            Discipline css = new Discipline("CSS3");

            // Creating teachers
            Teacher teacher1 = new Teacher("Nikolay Kostov");
            Teacher teacher2 = new Teacher("Ivaylo Kenov");
            Teacher teacher3 = new Teacher("Doncho Minkov");
            Teacher teacher4 = new Teacher("Evlogi Hristov");

            teacher1.AddDiscipline(javaScript, html, css);
            teacher2.AddDiscipline(cSharp);
            teacher3.AddDiscipline(html);
            teacher4.AddDiscipline(css);

            // Creating Group classes
            SchoolClass firstGroupClass = new SchoolClass("First Group-morning");
            SchoolClass secondGroupClass = new SchoolClass("Second Group-evening");

            firstGroupClass.AddTeacher(teacher1, teacher2);
            secondGroupClass.AddTeacher(teacher1, teacher3, teacher4);

            firstGroupClass.AddStudent(studentsFirstGroup);
            secondGroupClass.AddStudent(studentsSecondGroup);

            mySchool.AddClass(firstGroupClass);
            mySchool.AddClass(secondGroupClass);
            Console.WriteLine(mySchool);
        }
    }
}
