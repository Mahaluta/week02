
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesLinkedList
{
    class Program

    {
        public static void AddToLinkedListAfter(LinkedList<string> lista, string newElement, string afterElement)
        {
            var position = lista.Find(afterElement);
            lista.AddAfter(position, newElement);
        }

        public static void RemoveFromLinkedList(LinkedList<string> lista, string element)
        {
            var position = lista.Find(element);
            lista.Remove(element);
        }

        public static void PrintLinkedList(LinkedList<string> lista)
        {
            foreach (string element in lista)
                Console.Write(element + " ");
        }

        static void Main(string[] args)
        {
            // create linked List
            var names = new LinkedList<string>();
            names.AddFirst("Adrian");
            names.AddLast("Marius");
            AddToLinkedListAfter(names, "Codrin", "Adrian");
            AddToLinkedListAfter(names, "Alex", "Codrin");
            AddToLinkedListAfter(names, "Codrin", "Alex");
            AddToLinkedListAfter(names, "Daniel", "Codrin");
            AddToLinkedListAfter(names, "Tudor", "Daniel");


            // Display the list with duplicates
            Console.Write("The list is: ");
            PrintLinkedList(names);
            Console.WriteLine();

            // Checking for duplicates in the list
            bool Removing = true;
            while (Removing)
            {
                Removing = false;
                var nameToRemove = "";
                var lista = "";
                foreach (string name in names)
                {
                    if (lista.Contains(name))
                    {
                        nameToRemove = name;
                        Removing = true;
                        break;
                    }
                    lista = lista + name + " ";
                }
                if (nameToRemove != "")
                    RemoveFromLinkedList(names, nameToRemove);
            }

            // Display the list without duplicates
            Console.Write("The list without duplicates is: ");
            PrintLinkedList(names);

            Console.ReadKey();
        }


    }
}
