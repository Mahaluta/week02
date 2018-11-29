using System;

namespace Curs2
{
    public class DoWhileExample
    {
        public static void Main()
        {

        int x = Convert.ToInt32(Console.ReadLine());

        do {
            Console.WriteLine(x);
            x--;
        } while(x>0);


        } 
    }
}