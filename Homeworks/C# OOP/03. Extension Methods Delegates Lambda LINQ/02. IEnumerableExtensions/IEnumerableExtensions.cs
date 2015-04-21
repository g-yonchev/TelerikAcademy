namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T IEnumerableSum<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            T result = (dynamic)0;

            foreach (T item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T IEnumerableProduct<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            T result = (dynamic)1;

            foreach (T item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T IEnumerableMin<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            T min = collection.First();

            foreach (T item in collection)
            {
                if ((dynamic)item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T IEnumerableMax<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            T max = collection.First();

            foreach (T item in collection)
            {
                if ((dynamic)item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static double IEnumerableAverage<T>(this IEnumerable<T> collection)
            where T : IConvertible, IComparable
        {
            double result = collection.IEnumerableSum() / (dynamic)collection.Count();
            return result;
        }
    }
}
