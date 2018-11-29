using System;

namespace Curs2
{
    public class WhileExample
    {
        public static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            while(x>0)
            {
                
                Console.Write(x + ", ");
                x--;
            }
        }
    }
}