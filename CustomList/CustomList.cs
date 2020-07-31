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
    public class CustomList<T> : IEnumerable, IEnumerator, IList<T>, ICollection<T>
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
        public int Count
        {
            get
            {
                return count;
            }
        }
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
        // From ICollection
        public bool IsReadOnly => false;
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
                if (i < Count && i >= 0)
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
            EnsureCapacity(Count + 1);

            elements[Count] = value;
            count++;
        }
        /// <summary>
        /// Removes the first T value matching object from the <see cref="CustomList{T}" />.
        /// </summary>
        /// <param name="value">The value of the matching object to remove from the instance of <see cref="CustomList{T}" />.</param>
        /// <returns>Return true if an Item&lt;T&gt; with value successfully removed. Returns false if no object with matching value is found within CustomList&lt;T&gt;.</returns>
        public bool Remove(T value)
        {
            int index = IndexOf(value);
            if (index != -1 && index < Count)
            {
                RemoveAt(index);
                return true;
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
            CustomList<T> zipped = new CustomList<T>();
            // Iterate over the large of two lists
            int iterations = Count > listB.Count ? Count : listB.Count;
            for (int i = 0; i < iterations; i++)
            {
                if (i < Count)
                {
                    zipped.Add(this[i]);
                }
                if (i < listB.Count)
                {
                    zipped.Add(listB[i]);
                }
            }
            return zipped;
        }

        //public void ZipOnSelf(CustomList<T> listB)
        //{
        //    CustomList<T> zipped = new CustomList<T>();
        //    zipped.Add(ZipYield(this, listB);
        //}
        //public object ZipYield(CustomList<T> listA, CustomList<T> listB)
        //{
        //    int longerLength = listA.Count > listB.Count ? listA.Count : listB.Count;
        //    for(int i = 0; i < longerLength; i++)
        //    {
        //        if(i < listA.Count)
        //        {
        //            yield return listA[i];
        //        }
        //        if(i < listB.Count)
        //        {
        //            yield return listB[i];
        //        }
        //    }
        //}


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
            if (minuend == subtrahend)
            {
                minuend.Clear();
                return minuend;
            }
            foreach (T item in subtrahend)
            {
                minuend.Remove(item);
            }
            return minuend;
        }
        /// <summary>
        /// Determines whether the specified object as a <see cref="CustomList{T}" /> is equal to this instance. Similiar to Enumerable.SequenceEqual as only items in Count are compared and not Capacity.
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
        /// <summary>
        /// Returns a HashCode based on the sum of all object HashCodes in inner array, then adds HashCode for inner Array. WIP to make unique hashcode/best practice.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int hashCode = 0;
            foreach (object obj in this)
            {
                hashCode += obj.GetHashCode();
            }
            hashCode += elements.GetHashCode();
            return hashCode;
        }
        int position = -1; // for iteration
        // IEnumerator and IEnumerable required methods
        // WIP deciphering between two methods.
        public IEnumerator GetEnumerator()
        {

            return (IEnumerator)this;

            //return GetMyEnumerator();
            //for (int i = 0; i < count; i++)
            //{
            //    yield return elements[i];
            //}
        }
        //public IEnumerator GetMyEnumerator()
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        yield return elements[i];
        //    }
        //}
        // for IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < Count);
        }
        // for IEnumerable
        public void Reset()
        {
            position = -1;
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
            QuickSort(elements, 0, IndexOfLast);
        }
        public void QuickSort(T[] array, int start, int end)
        {
            if (start < end)
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

            for (int i = start; i < end; i++)
            {
                //Check against pivot value using Comparer<T>
                if (Comparer<T>.Default.Compare(array[i], pivot) <= 0)
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

        public int IndexOf(T item)
        {
            int lowerBounds = 0;
            for (int i = lowerBounds; i < Count; i++)
            {
                if (elements[i].Equals(item))
                {
                    return i;
                }
            }
            // Return -1 if not found.
            return -1;
        }
        public int IndexOf(T item, int startingIndex)
        {
            int lowerBounds = GetLowerBounds(startingIndex);
            if (lowerBounds == -1)
            {
                return -1;
            }

            for (int i = lowerBounds; i < Count; i++)
            {
                if (elements[i].Equals(item))
                {
                    return i;
                }
            }
            // Return -1 if not found.
            return -1;
        }
        public int IndexOf(T item, int startingIndex, int count)
        {
            // Lower index
            int lowerBounds = GetLowerBounds(startingIndex);
            if (lowerBounds == -1)
            {
                return -1;
            }
            // Upper Index
            int upperBounds = GetUpperBounds(lowerBounds, count);
            if (upperBounds == -1)
            {
                return -1;
            }

            for (int i = lowerBounds; i <= upperBounds; i++)
            {
                if (elements[i].Equals(item))
                {
                    return i;
                }
            }
            // Return -1 if not found.
            return -1;
        }
        public int GetLowerBounds(int index)
        {
            if (index < 0 || index >= Count)
            {
                return -1;
            }
            return index;
        }
        public int GetUpperBounds(int lowerBounds, int count)
        {
            if (lowerBounds + (count - 1) >= Count || count <= 0)
            {
                return -1;
            }
            // Include the first index in the sound.
            return lowerBounds + (count - 1);
        }


        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
            {
                return;
            }
            else if (index == Count)
            {
                this.Add(item);
                return;
            }
            ShiftItems(index, 1);
            elements[index] = item;
        }
        public void Insert(int index, T[] item)
        {
            if (index < 0 || index > Count)
            {
                return;
            }
            ShiftItems(index, item.Length);
            int itemIndex = 0;
            for (int i = index; i < index + item.Length; i++)
            {

                elements[i] = item[itemIndex];
                itemIndex++;
            }
        }
        public void Insert(int index, CustomList<T> listB)
        {
            if (index < 0 || index > Count)
            {
                return;
            }
            ShiftItems(index, listB.Count);
            int itemIndex = 0;
            for (int i = index; i < index + listB.Count; i++)
            {

                elements[i] = listB[itemIndex];
                itemIndex++;
            }
        }


        public void ShiftItems(int startIndex, int amount)
        {
            if (startIndex < 0 || startIndex > Count)
            {
                throw new IndexOutOfRangeException();
            }
            EnsureCapacity(Count + amount);

            count += amount;
            for (int i = (IndexOfLast); i >= startIndex + amount; i--)
            {
                elements[i] = elements[i - amount];
            }
        }


        private void EnsureCapacity(int minimum)
        {
            if (Capacity < minimum)
            {
                int newCapacity = Capacity == 0 ? startCapacity : Capacity * 2;
                int maxArrayCount = 0X7FEFFFFF;
                newCapacity = newCapacity > maxArrayCount ? maxArrayCount : newCapacity;
                newCapacity = newCapacity < minimum ? minimum : newCapacity;
                IncreaseCapacity(newCapacity);
            }
        }
        public void IncreaseCapacity(int newCapacity)
        {
            if (newCapacity <= Capacity)
            {
                return;
            }
            T[] newElements = new T[newCapacity];
            CopyTo(newElements, 0);
            // Assign to new array.
            elements = newElements;

        }


        public void RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
            {
                for (int i = index; i < IndexOfLast; i++)
                {
                    elements[i] = elements[i + 1];
                }
                elements[IndexOfLast] = default(T);
                count--;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                elements[i] = default(T);
            }
            count = 0;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1 ? true : false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex >= array.Length || arrayIndex + IndexOfLast >= array.Length)
            {
                throw new ArgumentException();
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            foreach (T item in this)
            {
                array[arrayIndex] = item;
                arrayIndex++;
            }
            // Bug with Foreach/IEnumerator not calling Reset on an empty list or null.
            Reset();
        }
        public void CopyTo(int index, T[] array, int arrayIndex, int count)
        {
            if (arrayIndex >= array.Length || arrayIndex + count - 1 >= array.Length)
            {
                throw new ArgumentException();
            }
            if (arrayIndex < 0 || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = index; i <= index + count - 1; i++)
            {
                array[arrayIndex] = elements[i];
                arrayIndex++;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

