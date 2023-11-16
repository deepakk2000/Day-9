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
            // Create an instance of LargeDataCollection
            using (var myCollection = new LargeDataCollection(new List<object> { 1, "Hello", new CustomObject() }))
            {
                // Demonstrate adding, removing, and accessing elements
                myCollection.AddElement(42);
                myCollection.RemoveElement("Hello");
                Console.WriteLine(myCollection.AccessElement(0));

                // Explicitly call Dispose to release resources
                myCollection.Dispose();
            }
        }
    }

    class CustomObject

        }
    }
}
