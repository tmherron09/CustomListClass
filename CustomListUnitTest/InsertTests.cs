using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListUnitTest
{
    [TestClass]
    public class InsertTests
    {

        [TestMethod]
        public void InsertMethod_Insert3AtIndex2Of1245_CL12345()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4, 5 };

            bool expected = true;
            bool actual;
            //  Act
            customList.Insert(2, 3);
            actual = (customList.Equals(customListTwo));

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertMethod_Insert1AtIndex0Of2345_CL12345()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4, 5 };

            bool expected = true;
            bool actual;
            //  Act
            customList.Insert(0, 1);
            actual = (customList.Equals(customListTwo));

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertMethod_Insert5AtIndex3Of1234_CL12354()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 5, 4 };

            bool expected = true;
            bool actual;
            //  Act
            customList.Insert(3, 5);
            actual = (customList.Equals(customListTwo));

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertMethod_Insert5AtIndex4Of1234_CL12345()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4, 5 };

            bool expected = true;
            bool actual;
            //  Act
            customList.Insert(4, 5);
            actual = (customList.Equals(customListTwo));

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
