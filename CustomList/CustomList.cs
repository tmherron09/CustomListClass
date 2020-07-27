using System;
using System.Collections.Generic;

namespace CustomListClass
{
    public class CustomList<T>
    {
        private T[] elements;
        private int count;
        private int startCapacity;

        public int Count { get { return count; } }
        public int Capacity 
        { 
            get 
            { 
                return elements.Length; 
            }

        }

        public CustomList()
        {
            elements = new T[0];
            startCapacity = 4;
            count = 0;
        }

        public void Add(T value)
        {
            count++;
            if(Capacity == 0)
            {
                T[] newElements = new T[startCapacity];
                elements = newElements;
            }
            else if(count > Capacity)
            {
                int newLength = elements.Length * 2;
                T[] newElements = new T[newLength];
                elements.CopyTo(newElements, 0);
                elements = newElements;
            }

            

            elements[count - 1] = value;
        }

        public bool Remove(T value)
        {
            throw new NotImplementedException();
        }


    }
}
