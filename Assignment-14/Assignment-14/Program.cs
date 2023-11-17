using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter element 1:");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter element 2:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter element 3:");
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter element 4:");
            string d = Console.ReadLine();
            var a = new object[] { a1, b, c, d, new object() };
            using (var LargeCollection = new LargeDataCollection(a))
            {
                LargeCollection.AddElement(44);
                Console.WriteLine("List after adding an element");
                LargeCollection.DisplayElement();
                LargeCollection.RemoveElement(a1);
                Console.WriteLine("List after removing an element");
                LargeCollection.DisplayElement();
                Console.WriteLine("Accessing The elements using index number");
                Console.WriteLine("Element at Index 0: " + LargeCollection.AccessElement(0));
                Console.WriteLine("Element at Index 2: " + LargeCollection.AccessElement(2));
            }
            Console.ReadKey();
        }
    }
}

