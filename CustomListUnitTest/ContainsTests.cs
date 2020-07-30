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
    public class ContainsTests
    {
        [TestMethod]
        public void ContainsMethod_CL12345Contains3_True()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };

            bool expected = true;
            bool actual;

            //  Act
            actual = customList.Contains(3);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContainsMethod_CL12345Contains6_False()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };

            bool expected = true;
            bool actual;

            //  Act
            actual = customList.Contains(3);

            //  Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
