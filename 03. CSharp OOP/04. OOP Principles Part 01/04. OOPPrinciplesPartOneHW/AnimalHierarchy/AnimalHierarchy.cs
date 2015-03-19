namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AnimalHierarchy
    {
        private static Random random = new Random();

        static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Kitten(GetRandomName(), GetRandomAge()),
                new Tomcat(GetRandomName(), GetRandomAge()),
                new Dog(GetRandomName(), GetRandomAge(), Gender.Male),
                new Cat(GetRandomName(), GetRandomAge(), Gender.Male),
                new Frog(GetRandomName(), GetRandomAge(), Gender.Female),
                new Frog(GetRandomName(), GetRandomAge(), Gender.Male)
            };

            Console.WriteLine("Some animals:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();

            var kittens = new List<Kitten>();
            for (int i = 0; i < 5; i++)
            {
                Kitten currerntKitten
                    = new Kitten(GetRandomName(), GetRandomAge());
                kittens.Add(currerntKitten);
            }

            double avrKitten = Kitten.CalculateAverageAge(kittens);
            Console.WriteLine("Kitten average age: " + avrKitten);

            var dogs = new List<Dog>();
            for (int i = 0; i < 5; i++)
            {
                Dog currerntDog
                    = new Dog(GetRandomName(), GetRandomAge(), Gender.Male);
                dogs.Add(currerntDog);
            }

            double avrDog = Dog.CalculateAverageAge(dogs);
            Console.WriteLine("Dog average age: " + avrDog);
        }

        static string GetRandomName()
        {
            string alphabet = "abcdefghijklmnopqrstuvwyxzeeeiouea";
            Func<char> randomLetter = () => alphabet[random.Next(alphabet.Length)];
            Func<int, string> makeName =
              (length) => new string(Enumerable.Range(0, length)
                 .Select(x => x == 0 ? char.ToUpper(randomLetter()) : randomLetter())
                 .ToArray());
            string name = makeName(random.Next(1) + 4);

            return name;
        }

        static int GetRandomAge()
        {
            return random.Next(0, 11);
        }
    }
}
