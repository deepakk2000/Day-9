using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    public class LargeDataCollection : IDisposable
    {
        private List<Object> list;
        private bool disposedvalue = false;
        public LargeDataCollection(params Object[] a)
        {
            list = new List<Object>(a);

            Console.WriteLine("List befor adding\\removing elements " + list.Count);
            Console.WriteLine("Elements in the list");
            foreach (Object o in list)
            {
                Console.WriteLine(o);
            }
        }
        public void AddElement(Object e)
        {
            if (!disposedvalue)
            {
                list.Add(e);
            }
            else
            {
                Console.WriteLine("Cannot add element after Disposal");
            }
        }

        public void RemoveElement(Object e)
        {
            if (!disposedvalue)
            {
                list.Remove(e);
            }
            else
            {
                Console.WriteLine("Cannot add element after Disposal");
            }
        }

        public object AccessElement(int i)
        {
            if (!disposedvalue && i >= 0 && i < list.Count)
            {
                return list[i];
            }
            else
            {
                Console.WriteLine("Invalid Index or element does not exist");
                return null;
            }
        }

        public void DisplayElement()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedvalue)
            {
                if (disposing)
                {
                    list.Clear();
                    list = null;
                }

                Console.WriteLine("Large data collection has been disposed");
                disposedvalue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~LargeDataCollection()
        {
            Dispose(false);
        }

    }
}
