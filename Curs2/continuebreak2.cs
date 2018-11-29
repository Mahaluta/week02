using System;

namespace Curs2
{
    public class ConvertExample
    {
        public static void Main()
        {
            /*  for(int i = 100; i>0; i--) {
                if(i%2==0) {
                    continue;
                }
                Console.WriteLine(i);
                */

            
            int i=7;
            while(i>0) {
                if(i==3) {
                    throw new Exception("It's over");
                }
                Console.WriteLine(i);
                i--;
            }
         }
    }
}
