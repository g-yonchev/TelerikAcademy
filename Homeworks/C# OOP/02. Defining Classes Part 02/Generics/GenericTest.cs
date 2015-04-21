namespace Generics
{
    using System;

    class GenericTest
    {
        static void Main()
        {
            var someList = new GenericList<double>(4);

            for (int i = 0; i < 5; i++)
            {
                someList.AddElement(i + 2.5);
            }

            someList.InsertAtIndex(0, -12.5);
            someList.InsertAtIndex(0, -16.3);

            for (int i = 0; i < someList.Count; i++)
            {
                Console.WriteLine(someList[i]);
            }

            someList.Clear();
            Console.WriteLine(someList.Count);
        }
    }
}
