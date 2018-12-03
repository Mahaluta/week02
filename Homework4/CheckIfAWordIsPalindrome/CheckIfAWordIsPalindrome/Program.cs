using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfAWordIsPalindrome
{
    class Program { 

        public static string ReverseString(string text)
    {
        char[] arr = text.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public static bool isPalindrome(string pali)
    {
        if (pali == ReverseString(pali))
            return true;
        return false;
    }
    
        static void Main()
        {
            Console.WriteLine("Read a string to see if it's a palindrome: ");
            string pali = Console.ReadLine();

            Console.WriteLine(isPalindrome(pali)
               ? "The word '" + pali + "' is a palindrome."
               : "The word '" + pali + "' is not a palindrome.");

            
            Console.ReadKey();
        }
    }
}
