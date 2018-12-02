using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharacters
{
    class Program
    {
        public static bool UniqueCharacters(string word)
        {

            for (int i = 0; i < word.Length; i++)
                for (int j = i + 1; j < word.Length; j++)
                    if ((word[i] == word[j]))
                        return false;
            return true;
        }

        static void Main()
        {
            Console.WriteLine("Read a string to see if it has unique characters: ");
            string word = Console.ReadLine();

            if (UniqueCharacters(word.ToLower()) == true)
                Console.WriteLine("The word '" + word + "' has unique characters.");
            else
                Console.WriteLine("The word '" + word + "' doesn't have unique characters.");

            Console.ReadKey();
        }
    }
}
