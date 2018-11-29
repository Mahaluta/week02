using System;
namespace ConsoleApplication
{
    public class ReadV
    {
        public static void Main()
        {
            string temp = Console.ReadLine();
            int number = Convert.ToInt32(temp);

                if(number>100){
            Console.WriteLine("BIGGER"); 
                }
                else if(number<100){ 
            Console.WriteLine("SMALLER");
            }
                else{
                    Console.WriteLine("NUMBER = 100");
                }
                


        }
    }
}

