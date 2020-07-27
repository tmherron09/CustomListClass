using System;
using System.Net.NetworkInformation;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListUnitTest
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void AddMethod_AddInt10_CountIsOne()
        {
            //  Arrange
            CustomList<int> list = new CustomList<int>();

            int expected;
            int actual;

            //  Act

            list.Add(10);
            actual = list.Count;

            //  Assert





        }
    }
}
