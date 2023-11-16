using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    internal class LargeDataCollection:IDisposable
    {
        private List<object> dataCollection;

        public LargeDataCollection(IEnumerable<object> initialData)
        {
            dataCollection = new List<object>(initialData);
        }

        public void AddElement(object element)
        {
            dataCollection.Add(element);
        }

        public void RemoveElement(object element)
        {
            dataCollection.Remove(element);
        }

        public object AccessElement(int index)
        {
            if (index >= 0 && index < dataCollection.Count)
                return dataCollection[index];
            else
                return null; // or throw an exception based on your requirements
        }

        public void Dispose()
        {
            // Release any unmanaged resources here
            // Example: Close connections, file handles, etc.

            // Set the internal data structure to null
            dataCollection = null;

            // Optionally, suppress finalization if not needed
            GC.SuppressFinalize(this);
        }
    }
}
