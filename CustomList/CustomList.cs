using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomListClass
{
    /// <summary>
    /// Custom List class of Type Generic
    /// </summary>
    /// <typeparam name="T">Type of Item in CustomList</typeparam>
    public class CustomList<T> : IEnumerator, IEnumerable
    {
        private T[] elements;
        private int count;
        private const int startCapacity = 4;
        int position = -1; // for iteration

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
        public CustomList<T> Zip(CustomList<T> listB)
        {
            CustomList<T> zipped = new CustomList<T>(Count + listB.Count);
            // Iterate over the large of two lists
            int iterations = Count > listB.Count ? Count : listB.Count;
            for(int i = 0; i < iterations; i++)
            {
                if(i < Count)
                {
                    zipped.Add(this[i]);
                }
                if(i < listB.Count)
                {
                    zipped.Add(listB[i]);
                }
            }

            return zipped;
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

            CustomList<T> difference = new CustomList<T>();
            difference += minuend;

            List<int> valuesToSubtract = new List<int>();
            List<int> subtrahendSubtractedIndexs = new List<int>();

            for (int i = 0; i < minuend.Count; i++)
            {
                for (int j = 0; j < subtrahend.Count; j++)
                {
                    if (minuend[i].Equals(subtrahend[j]) && !subtrahendSubtractedIndexs.Contains(j))
                    {
                        valuesToSubtract.Add(i);
                        subtrahendSubtractedIndexs.Add(j);
                        break;
                    }
                }
            }
            for (int i = 0; i < valuesToSubtract.Count; i++)
            {
                difference.Remove(minuend[valuesToSubtract[i]]);
            }

            return difference;
        }


        // IEnumerator and IEnumerable required methods
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        // for IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < Count);
        }
        // for IEnumerable
        public void Reset()
        {
            position = 0;
        }
        // for IEnumerable
        public object Current
        {
            get
            {
                return elements[position];
            }
        }
    }
}

