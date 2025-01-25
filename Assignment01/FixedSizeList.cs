using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int currentSize;

        // Constructor to initialize the list with a fixed capacity
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            items = new T[capacity];
            currentSize = 0;
        }

        // Add method to add an element to the list
        public void Add(T item)
        {
            if (currentSize >= items.Length)
            {
                throw new InvalidOperationException("The list is full. Cannot add more elements.");
            }

            items[currentSize] = item;
            currentSize++;
        }

        // Get method to retrieve an element at a specific index
        public T Get(int index)
        {
            if (index < 0 || index >= currentSize)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            return items[index];
        }

        // Method to return the current number of elements in the list
        public int Count()
        {
            return currentSize;
        }
    }
}
