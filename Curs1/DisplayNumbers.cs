using System;
namespace ConsoleApplication
{
    public class DisplayNumbers
    {
        public static void Main()
        {
           Console.WriteLine("Count from 1 to 10.");
           bool goon = false;
            for (int i=10; goon;i++)
                Console.WriteLine(i);
                if(i==10)
                {
                    stop=true;
                }
        }
    }
}