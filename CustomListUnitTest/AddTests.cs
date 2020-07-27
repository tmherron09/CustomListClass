using System;
using System.Net.NetworkInformation;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class AddTests
    {
        // Test Add Method Type Int
        [TestMethod]
        public void AddMethod_AddInt10_CountIsOne()
        {
            //  Arrange
            CustomList<int> list = new CustomList<int>();

            int expected = 1;
            int actual;

            //  Act

            list.Add(10);
            actual = list.Count;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add5Ints_CountIsFive()
        {
            //  Arrange
            CustomList<int> list = new CustomList<int>();

            int expected = 5;
            int actual;

            //  Act

            list.Add(10);
            list.Add(12);
            list.Add(0);
            list.Add(5);
            list.Add(7);
            actual = list.Count;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add1Int6_IndexAt0Is6()
        {
            //  Arrange
            CustomList<int> list = new CustomList<int>();

            int expected = 6;
            int actual;

            //  Act
            list.Add(6);
            actual = list[0];

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add1Through5_Index0Is1()
        {
            //  Arrange
            CustomList<int> list = new CustomList<int>();

            int expected = 1;
            int actual;

            //  Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            actual = list[0];
            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_Add1Through5_Index4Is5()
        {
            //  Arrange
            CustomList<int> list = new CustomList<int>();

            int expected = 5;
            int actual;

            //  Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            actual = list[4];

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_EmptyCustomList_CapacityIs0()  // Arbitrary Capacity unless
        {
            //  Arrange
            CustomList<int> list = new CustomList<int>();

            int expected = 0;
            int actual;

            //  Act
            actual = list.Capacity;

            //  Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddMethod_AddInt5_CapacityIs6()  // Arbitrary Capacity unless
        {
            //  Arrange
            CustomList<int> list = new CustomList<int>();

            int expected = 6;
            int actual;

            //  Act
            actual = list.Capacity;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]  // According to intellisense throws when can't cast string to int?
        public void AddMethod_AddStringToCustomListTypeInt_ThrowException()  //Fail or throw exception?
        {
            //  Arrange
            CustomList<int> list = new CustomList<int>();

            //  Act
            list.Add("Hello Exception");
        }
        // Test Add Method Type String
        [TestMethod]
        public void AddMethod_AddOneString_CountIsOne()
        {
            //  Arrange
            CustomList<string> list = new CustomList<string>();

            int expected = 1;
            int actual;

            //  Act
            list.Add("Hello Custom World");
            actual = list.Count;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMethod_AddThreeString_CountIsThree()
        {
            //  Arrange
            CustomList<string> list = new CustomList<string>();

            int expected = 3;
            int actual;

            //  Act
            list.Add("Hello Custom World");
            list.Add("This bad boy can fit so many tests.");
            list.Add("Is this a Butterfly?");
            actual = list.Count;

            //  Assert
            Assert.AreEqual(expected, actual);
        }




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
