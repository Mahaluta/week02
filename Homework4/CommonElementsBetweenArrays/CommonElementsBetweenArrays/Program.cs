using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElementsBetweenArrays
{
    class Program
    {
        public static void CommonElements(int[] arr1, int[] arr2)
        {
            var intersection = arr1.Intersect(arr2);
            foreach (int element in intersection)
            {
                Console.Write(element + " ");
            }
        }

        static void Main()
        {
            int[] arr1 = { 1, 3, -4, 8, -2, 9, 10, 14 };
            int[] arr2 = { 1, 1, 5, 3, 8, 3, -4, 5, 13 };
            Console.Write("Common elements arr1 and arr2: ");
            CommonElements(arr1, arr2);

            Console.ReadKey();
        }
    }
}
