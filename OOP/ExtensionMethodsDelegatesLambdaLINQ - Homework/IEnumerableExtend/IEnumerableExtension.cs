//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
namespace IEnumerableExtend
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public static class IEnumerableExtension // Task 2
    {

        public static T SumOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)0;

            foreach (T item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T ProductOfCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)1;

            foreach (T item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T MinValueInCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Min();
        }

        public static T MaxValueInCollection<T>(this IEnumerable<T> collection) where T : struct
        {
            return collection.Max();
        }

        public static double CollectionAverage<T>(this IEnumerable<T> collection) where T : struct
        {
            return (dynamic)collection.SumOfCollection() / collection.Count();
        }
    }
}
