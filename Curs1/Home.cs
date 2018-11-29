using System;
namespace ConsoleApplication
{
    public class Home
    {
        public static int AddNumbers(int a, int b) { return a + b; }
        public static int SubNumbers(int a, int b) { return a - b; }
        public static int MulNumbers(int a, int b) { return a * b; }
        public static int DivNumbers(int a, int b) { return a / b; }
        public static void ConvertScale(int c, string d)
        {
            if ((d == "F") || (d == "f"))
                Console.WriteLine((c - 32) * 5 / 9 + " C");
            else if ((d == "C") || (d == "c"))
                Console.WriteLine(c * 9 / 5 + 32 + " F");
            else
                Console.WriteLine("Not a valid scale.");
        }
        //How many Years/Months/Weeks are in the number 'e' with accuracy (float)
        public static void ConvertYMW2(float e)
        {
            Console.WriteLine(e / 365 + " years");
            Console.WriteLine((e / 365 * 12) + " months");
            Console.WriteLine(e / 365 * 12 * 7 + " weeks");
        }

        public static void ConvertYMW(int e)
        {
            Console.WriteLine(e / 365 + " years");
            Console.WriteLine((e % 365) / 30 + " months");
            Console.WriteLine((((e % 365) % 30) / 7) + " weeks");
            Console.WriteLine(((((e % 365) % 30) % 7)) + " days");
        }
        public static void Main()
        {

            // ADD & SUB & MUL & DIV
            Console.WriteLine("Read 2 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is " + AddNumbers(a, b));
            Console.WriteLine("The sub is " + SubNumbers(a, b));
            Console.WriteLine("The mul is " + MulNumbers(a, b));
            Console.WriteLine("The div is " + DivNumbers(a, b));

            // EVEN/ODD
            Console.WriteLine("Read an Even or Odd number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
                Console.WriteLine(x + " is an even number.");
            else
                Console.WriteLine(x + " is an odd number.");

            // FROM 1 TO 10
            Console.WriteLine("Count from 1 to 10.");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i);

            // CONVERT SCALE
            Console.WriteLine("Read a number and the letter C/F to convert the temperature: ");
            int c = Convert.ToInt32(Console.ReadLine());
            string d = Console.ReadLine();
            ConvertScale(c, d); // void function

            //CONVERT NUMBER TO Y/M/W2
            Console.WriteLine("Read a numebr to convert it to Y/M/W: ");
            int e = Convert.ToInt32(Console.ReadLine());
            while (e < 1000)
            {
                Console.WriteLine("Read a number >= 1000: ");
                e = Convert.ToInt32(Console.ReadLine());
            }
            ConvertYMW(e); // void function with float argument



        }
    }
}

