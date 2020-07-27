using System;
using System.Net.NetworkInformation;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class AddMethodTests
    {
        // Test Add Method Type Int
        [TestMethod]
        public void AddMethod_AddInt10_CountIsOne()
        {
            //  Arrange
            CustomList<int>customList = new CustomList<int>();

            int expected = 1;
            int actual;

            //  Act

           customList.Add(10);
            actual =customList.Count;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add5Ints_CountIsFive()
        {
            //  Arrange
            CustomList<int>customList = new CustomList<int>();

            int expected = 5;
            int actual;

            //  Act

           customList.Add(10);
           customList.Add(12);
           customList.Add(0);
           customList.Add(5);
           customList.Add(7);
            actual =customList.Count;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_EmptyCustomListTypeInt_CountIs0()
        {
            //  Arrange
            CustomList<int>customList = new CustomList<int>();

            int expected = 0;
            int actual;

            //  Act
            actual =customList.Count;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add1Int6_IndexAt0Is6()
        {
            //  Arrange
            CustomList<int>customList = new CustomList<int>();

            int expected = 6;
            int actual;

            //  Act
           customList.Add(6);
            actual =customList[0];

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add1Through5_Index0Is1()
        {
            //  Arrange
            CustomList<int>customList = new CustomList<int>();

            int expected = 1;
            int actual;

            //  Act
           customList.Add(1);
           customList.Add(2);
           customList.Add(3);
           customList.Add(4);
           customList.Add(5);
            actual =customList[0];
            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add1Through5_Index4Is5()
        {
            //  Arrange
            CustomList<int>customList = new CustomList<int>();

            int expected = 5;
            int actual;

            //  Act
           customList.Add(1);
           customList.Add(2);
           customList.Add(3);
           customList.Add(4);
           customList.Add(5);
            actual =customList[4];

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_EmptyCustomList_CapacityIs0()  // Arbitrary Capacity unless
        {
            //  Arrange
            CustomList<int>customList = new CustomList<int>();

            int expected = 0;
            int actual;

            //  Act
            actual =customList.Capacity;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_AddInt5_CapacityIs6()  // Arbitrary Capacity unless
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();

            int expected = 6;
            int actual;

            //  Act
            customList.Add(5);
            actual = customList.Capacity;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add1ThroughyIs6_CapacityIs6()  // Arbitrary Capacity unless
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();

            int expected = 6;
            int actual;

            //  Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            actual = customList.Capacity;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add1ThroughyIs7_CapacityIs12()  // Arbitrary Capacity unless
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();

            int expected = 12;
            int actual;

            //  Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            actual = customList.Capacity;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add1ThroughyIs500_CapacityIs504()  // (500 / 6) times capacity grew + 1 (for left over 498, 499) * 6
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();

            int expected = 504;
            int actual;

            //  Act
            for(int i = 1; i <= 500; i++)
            {
                customList.Add(i);
            }
            actual = customList.Capacity;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        
        
       















        //  Personal Bonus maybe
        //[TestMethod]
        //public void AddMethod_AddInt1ToCustomListTypeString_Contains1AsString() // After MVP?- Correct casting or ToString used
        //{
        //    //  Arrange
        //    CustomList<string> list = new CustomList<string>();
        //    int expected = "1";
        //    int actual;
        //    //  Act
        //    list.Add(1);
        //    actual = list[0];
        //    //  Assert
        //    Assert.AreEqual(expected, actual);
        //}
        // After MVP- Test AddMethod use of Args[] to Differentiate from List<T> -   .Add(T value)     .Add(T[] args)
        //[TestMethod]
        //public void AddMethod_5IntParameters_CountIs5()
        //{
        //    //  Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    int expected = 5;
        //    int actual;
        //    //  Act
        //    list.Add(1, 2, 3, 4, 5);
        //    actual = list.Count;
        //    //  Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //  Additional to go with Above
        //[TestMethod]
        //public void AddMethod_IntArrayOf5Ints_CountIs5()
        //{
        //    //  Arrange
        //    CustomList<int> list = new CustomList<int>();
        //    int[] intArray = new int[] { 1, 2, 3, 4, 5 };
        //    int expected = 5;
        //    int actual;
        //    //  Act
        //    list.Add(intArray);
        //    actual = list.Count;
        //    //  Assert
        //    Assert.AreEqual(expected, actual);
        //}




        //  Copy Past For Faster Writting
        //[TestMethod]
        //public void AddMethod()
        //{
        //    //  Arrange
        //    CustomList<int> list = new CustomList<int>();

        //    int expected;
        //    int actual;

        //    //  Act

        //    //  Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
