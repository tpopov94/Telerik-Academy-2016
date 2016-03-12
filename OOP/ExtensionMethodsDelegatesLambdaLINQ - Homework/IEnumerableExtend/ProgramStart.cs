using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtend
{
    public class ProgramStart
    {
        static void Main()
        {
            //Testing of the various extensions for different types of collections and elements:

            IEnumerable<int> test = new List<int>() { 1, 2, 3, 4, 5, 6 , 7 };

            Console.WriteLine("Sum of Collection: " + test.SumOfCollection());

            IEnumerable<double> test1 = new[] { 1.2, 0.5, 23.5, 4, 5 };

            Console.WriteLine("Sum of Collection: " + test1.SumOfCollection());
            Console.WriteLine("Product of Collection: " + test1.ProductOfCollection());
            Console.WriteLine("Min of Collection: " + test1.MinValueInCollection());
            Console.WriteLine("Max of Collection: " + test1.MaxValueInCollection());
            Console.WriteLine("Average of Collection: " + test1.CollectionAverage());
        }
    }
}
