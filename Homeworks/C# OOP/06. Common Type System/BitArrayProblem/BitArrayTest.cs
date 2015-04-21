/*  Problem 5. 64 Bit array
        Define a class BitArray64 to hold 64 bit values inside an ulong value.
        Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
*/

namespace BitArrayProblem
{
    using System;

    public class BitArrayTest
    {
        public static void Main()
        {
            var testNumber = new BitArray64(254);

            // number as array of bits:
            Console.WriteLine(string.Join("", testNumber.BitArray));

            // check indexer
            Console.WriteLine(testNumber[60]);
            Console.WriteLine(testNumber[5]);

            // check enumerator
            foreach (var bit in testNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            //check equals and ==
            var testNumber2 = new BitArray64(254);
            var testNumber3 = new BitArray64(122);

            Console.WriteLine(testNumber.Equals(testNumber2));
            Console.WriteLine(testNumber.Equals("11111110"));
            Console.WriteLine(testNumber.Equals(testNumber3));
            Console.WriteLine(testNumber == testNumber2);
            Console.WriteLine(testNumber != testNumber3);
        }
    }
}
