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
