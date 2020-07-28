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
            CustomList<T> sum = new CustomList<T>(first.Count + second.Count);

            for (int i = 0; i < first.Count; i++)
            {
                sum.Add(first[i]);
            }
            for (int i = 0; i < second.Count; i++)
            {
                sum.Add(second[i]);
            }


            return sum;
        }

        /// <summary>
        /// Determines whether the specified object as a CustomList is equal to this instance.
        /// </summary>
        /// <param name="value">The <see cref="CustomList{T}" /> to compare with this instance.</param>
        /// <returns>
        ///   True if the specified <see cref="CustomList{T}" /> items in elements array are equal to at the same indexs of this instance; Else, false 
        /// </returns>
        public override bool Equals(object value)
        {
            CustomList<T> customList = value as CustomList<T>;

            if (Count != customList.Count)
            {
                return false;
            }
            for (int i = 0; i < customList.Count; i++)
            {
                if (!elements[i].Equals(customList[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static CustomList<T> operator -(CustomList<T> minuend, CustomList<T> subtrahend)
        {
            // New CustomList cannot be larger than the minuend
            CustomList<T> difference = new CustomList<T>(minuend.Count);
            difference += minuend;

            int[] valuesToSubtract = new int[minuend.Count];
            int indexOfValuesToSubtract = 0;

            for (int i = 0; i < minuend.Count; i++)
            {
                for (int j = 0; j < subtrahend.Count; j++)
                {
                    if (minuend[i].Equals(subtrahend[j]))
                    {
                        valuesToSubtract[indexOfValuesToSubtract] = i;
                        indexOfValuesToSubtract++;
                        break;
                    }
                }
            }
            for (int i = 0; i < valuesToSubtract.Length; i++)
            {
                difference.Remove(minuend[valuesToSubtract[i]]);
            }



            return difference;
        }
    }
}

