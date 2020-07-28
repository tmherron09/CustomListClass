using System;
using System.Collections.Generic;
using System.Text;

namespace CustomListClass
{
    public class CustomList<T>
    {
        private T[] elements;
        private int count;
        private const int startCapacity = 4;
        

        public int Count { get { return count; } }
        public int Capacity
        {
            get
            {
                return elements.Length;
            }

        }
        public int indexOfLast // If -1, Custom List is Empty
        { 
            get
            {
                return Count - 1;
            }
        }
        public T this[int i]
        {
            get
            {
                if (i <= indexOfLast && indexOfLast >= 0)  // Prevent/skip array check of negative numbers.
                {
                    return elements[i];
                }
                throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (i <= indexOfLast && indexOfLast >= 0)
                {
                    elements[i] = value;
                }
                throw new ArgumentOutOfRangeException();
            }
        }

        public CustomList()
        {
            elements = new T[0];
            count = 0;
        }
        public CustomList(int capacity)
        {
            elements = new T[capacity];
            count = 0;
        }

        public void Add(T value)
        {
            count++;
            if (Capacity == 0)
            {
                T[] newElements = new T[startCapacity];
                elements = newElements;
            }
            else if (count > Capacity)
            {
                int newLength = elements.Length * 2;
                T[] newElements = new T[newLength];
                elements.CopyTo(newElements, 0);
                elements = newElements;
            }
            elements[indexOfLast] = value;
        }

        public bool Remove(T value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (elements[i].Equals(value))
                {
                    while (i != Count - 1)
                    {
                        elements[i] = elements[i + 1];
                        i++;
                    }
                    elements[i] = default(T);
                    count--;
                    return true;
                }
            }
            return false;
        }



        public override string ToString()
        {
            if (Count == 0)
            {
                return "Empty Custom List";
            }

            // Set initial capacity to 10 per item
            StringBuilder sb = new StringBuilder(Count * 10);
            sb.Append(elements[0]);
            for (int i = 1; i < Count; i++)
            {
                if (elements[i] != null)
                {
                    sb.Append(", ");
                    sb.Append(elements[i]);
                }
            }


            return sb.ToString();
        }

        public static CustomList<T> operator +(CustomList<T> first, CustomList<T> second)
        {



            throw new NotImplementedException();
        }



    }
}

