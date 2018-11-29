using System;
namespace ConsoleApplication
{
    public class ConvertDate
    {
        public static void ConvertYMWD(int e)
        {
            Console.WriteLine(e / 365 + " years");
            Console.WriteLine((e % 365) / 30 + " months");
            Console.WriteLine((((e % 365) % 30) / 7) + " weeks");
            Console.WriteLine(((((e % 365) % 30) % 7)) + " days");
        }
        public static void Main()
        {
                Console.WriteLine("Read a numebr to convert it to Y/M/W/D: ");
            int e = Convert.ToInt32(Console.ReadLine());
            while (e < 1000)
            {
                Console.WriteLine("Read a number >= 1000: ");
                e = Convert.ToInt32(Console.ReadLine());
            }
            ConvertYMWD(e);
        }
    }
}