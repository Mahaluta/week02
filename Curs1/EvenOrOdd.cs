using System;
namespace ConsoleApplication
{
    public class EvenOrOdd
    {
        public static int modulo(int a, int b)
        {
            return a % b;
        }
        public static void Main()
        {
            Console.WriteLine("Read an Even or Odd number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
                Console.WriteLine(x + " is an even number.");
            else
                Console.WriteLine(x + " is an odd number.");

            Console.WriteLine(modulo(10, 5));
        }




    }
}