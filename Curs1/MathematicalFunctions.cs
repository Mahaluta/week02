using System;
namespace ConsoleApplication
{
    public class MathFunctions
    {
        public static int AddNumbers(int a, int b) { return a + b; }
        public static int SubNumbers(int a, int b) { return a - b; }

        public static int DivNumbers(int a, int b)
        {
            if (b == 0)
                return -1;
            else
                return a / b;
        }

        public static string test() {
            return "DA";
        }

        public static void Main()
        {
            Console.WriteLine("Read 2 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is: " + AddNumbers(a, b));
            Console.WriteLine("The sub is: " + SubNumbers(a, b));
            if (b == 0)
                Console.WriteLine("Can't divide by 0");
                else
                Console.WriteLine("The div is: " + DivNumbers(a, b));
            string c = test();
            Console.WriteLine(c);



        }
    }
}

