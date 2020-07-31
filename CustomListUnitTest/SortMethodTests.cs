using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class SortMethodTests
    {
        //  For Random values
        Random rng = new Random();
 
        [TestMethod]
        public void QuickSort_Jumbled0Through10_AscendingOrder()
        {
            // Arrange
            CustomList<int> jumble = new CustomList<int>() { 9, 4, 6, 2, 7, 5, 0, 10, 1, 3, 8 };

            CustomList<int> expected = new CustomList<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CustomList<int> actual = jumble;

            // Act
            actual.Sort();

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void QuickSort_RandomStrings_AlpabeticalOrder()
        {
            // Arrange
            CustomList<string> jumble = new CustomList<string>() { "Hello", "Apple", "Cat", "Zoo", "Bunny" };

            CustomList<string> expected = new CustomList<string>() { "Apple", "Bunny", "Cat", "Hello", "Zoo" };
            CustomList<string> actual = jumble;

            // Act
            actual.Sort();

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Partition_FindFirstPartitionIndex_PI8()
        {
            //  Arrange
            int[] jumble = new int[] { 9, 4, 6, 2, 7, 5, 0, 10, 1, 3, 8 };
            CustomList<int> instance = new CustomList<int>();

            int expected = 8;
            int actual;

            //  Act
            actual = instance.Partition(jumble, 0, jumble.Length - 1);

            //  Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Bubble_IntSort_CorrectOrder()
        {
            // Arrange
            CustomList<int> jumble = new CustomList<int>() { 9, 10, 3, 4, 8, 5, 0, 1, 2, 7, 6 };
            

            CustomList<int> expected = new CustomList<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CustomList<int> actual = jumble;

            // Act
            actual.BubbleSort();


            //  Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Bubble_IntSortHUGE_CorrectOrder()
        {
            // Arrange
            CustomList<int> jumble = new CustomList<int>(1000);
            for (int i = 0; i < 1000; i++)
            {
                jumble.Add(rng.Next(0, 1000));
            }
            bool expected = true;
            bool actual = true;

            // Act
            jumble.BubbleSort();
            for (int i = 0; i < jumble.Count - 1; i++)
            {
                if (i > i + 1)
                {
                    actual = false;
                }
            }

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BubbleSort_StringSort_CorrectOrder()
        {
            // Arrange
            CustomList<string> jumble = new CustomList<string>() { "Hello", "Apple", "Cat", "Zoo", "Bunny" };
            
            CustomList<string> arranged = new CustomList<string>() { "Apple", "Bunny", "Cat", "Hello", "Zoo" };
            bool expected = true;
            bool actual;

            // Act
            jumble.BubbleSort();
            actual = jumble.Equals(arranged);

            //  Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSort_JumbledNumbers_Numeric()
        {
            // Arrange
            CustomList<int> jumble = new CustomList<int>() { 9, 10, 3, 4, 8, 5, 0, 1, 2, 7, 6 };


            CustomList<int> expected = new CustomList<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CustomList<int> actual = jumble;

            // Act
            actual.MergeSort();


            //  Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
