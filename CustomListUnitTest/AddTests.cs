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
