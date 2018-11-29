using System;
namespace ConsoleApplication
{
    public class Converter
    {
        public static void ConvertScale(int c, string d)
        {
            if ((d == "F") || (d == "f"))
                Console.WriteLine((c - 32) * 5 / 9 + " C");
            else if ((d == "C") || (d == "c"))
                Console.WriteLine(c * 9 / 5 + 32 + " F");
            else
                Console.WriteLine("Not a valid scale.");
        }

        public static void Main()
        {

            Console.WriteLine("Read a number and the letter C/F to convert the temperature: ");
            int c = Convert.ToInt32(Console.ReadLine());
            string d = Console.ReadLine();
            ConvertScale(c, d);

        }
    }
}