using System;
using System.Collections;
using System.Collections.Concurrent;
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
        /// <summary>
        /// Inner Array of <see cref="CustomList{T}" />
        /// </summary>
        private T[] elements;
        /// <summary>
        /// Number of Items in <see cref="CustomList{T}" />
        /// </summary>
        private int count;
        /// <summary>
        /// Default capacity of a non-empty CustomList
        /// </summary>
        private const int startCapacity = 4;
        /// <summary>
        /// Public readonly value of numer of items in <see cref="CustomList{T}" />
        /// </summary>
        public int Count { get { return count; } }
        /// <summary>
        /// Publicly accessible length of iternal array elements
        /// </summary>
        public int Capacity
        {
            get
            {
                return elements.Length;
            }

        }
        /// <summary>
        /// The index position of the last element in the array.
        /// </summary>
        public int IndexOfLast // If -1, Custom List is Empty
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
                if (i <= IndexOfLast && IndexOfLast >= 0)  // Prevent/skip array check of negative numbers.
                {
                    return elements[i];
                }
                throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (i <= IndexOfLast && IndexOfLast >= 0)
                {
                    elements[i] = value;
                }
                throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// Initializes a new instance of <see cref="CustomList{T}" /> Class
        /// </summary>
        public CustomList()
        {
            elements = new T[0];
            count = 0;
        }
        /// <summary>
        /// Initializes a new instance of <see cref="CustomList{T}" /> Class that is empty and has specified starting capacity. 
        /// </summary>
        /// <param name="capacity">Value to initialize capacity.</param>
        public CustomList(int capacity)
        {
            elements = new T[capacity];
            count = 0;
        }
        /// <summary>
        /// Method to add a <see cref="CustomList{T}" /> to end of <paramref name="this"/> inner array.
        /// </summary>
        /// <param name="value"><see cref="CustomList{T}" /> to Add to end of inner array.</param>
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
            elements[IndexOfLast] = value;
        }
        /// <summary>
        /// Removes the first T value matching object from the <see cref="CustomList{T}" />.
        /// </summary>
        /// <param name="value">The value of the matching object to remove from the instance of <see cref="CustomList{T}" />.</param>
        /// <returns>Return true if an Item&lt;T&gt; with value successfully removed. Returns false if no object with matching value is found within CustomList&lt;T&gt;.</returns>
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
        /// <summary>
        /// Zips together a second <see cref="CustomList{T}" />. New <see cref="CustomList{T}" /> will contain <paramref name="this"/> first item in inner array, proceeded by <paramref name="listB"/> first item in inner array and repeat until all items have been added to new <see cref="CustomList{T}" />. Trailing items will be added to returned <see cref="CustomList{T}" />.
        /// </summary>
        /// <param name="listB"><see cref="CustomList{T}" /> to Zip</param>
        /// <returns>New <see cref="CustomList{T}" /> of <paramref name="this"/> zipped with <paramref name="listB"/> </returns>
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
        /// <summary>
        /// Converts contents of <see cref="CustomList{T}" /> to string. String format includes $"elements[0], elements[1], elements[3]..." for all items.
        /// </summary>
        /// <returns>String of "elements[0], elements[1], elements[3]..."</returns>
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
        /// <summary>
        /// Defines + operator overload for adding two <see cref="CustomList{T}" />.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>New <see cref="CustomList{T}" /> of both inner arrays joined.</returns>
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
        /// Defines - operator overload for subtracting two <see cref="CustomList{T}" />.
        /// </summary>
        /// <param name="minuend"><see cref="CustomList{T}" /> being subtracted from.</param>
        /// <param name="subtrahend"><see cref="CustomList{T}" /> to subtract from <paramref name="minuend"/> </param>
        /// <returns></returns>
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
        /// <summary>
        /// Determines whether the specified object as a <see cref="CustomList{T}" /> is equal to this instance.
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

        int position = -1; // for iteration
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
    
    
        public void Sort()
        {
            QuickSort(elements, 0, Count - 1);
        }
        public void QuickSort(T[] array, int start, int end)
        {
            if(start < end)
            {
                // Get the pivot point of the current array section
                int pi = Partition(elements, start, end);

                QuickSort(array, start, pi - 1);
                QuickSort(array, pi + 1, end);
            }
        }

        public int Partition(T[] array, int start, int end)
        {
            int smallerIndex = (start - 1);
            T pivot = array[end];
            T temp;

            for(int i = start; i < end; i++)
            {
                //Check against pivot value using Comparer<T>
                if(Comparer<T>.Default.Compare(array[i], pivot) <= 0)
                {
                    smallerIndex++;

                    // Swap
                    temp = array[smallerIndex];
                    array[smallerIndex] = array[i];
                    array[i] = temp;
                }
            }
            // swap with pivot
            temp = array[smallerIndex + 1];
            array[smallerIndex + 1] = array[end];
            array[end] = temp;
            return smallerIndex + 1;

        }


    
    }
}

