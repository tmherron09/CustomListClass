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
        [TestMethod]
        public void InsertMethod_InsertArray345AtIndex4Of15_CL12345()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int[] insertNumbers = { 2, 3, 4 };
            bool expected = true;
            bool actual;
            //  Act
            customList.Insert(1, insertNumbers);
            actual = (customList.Equals(customListTwo));

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertMethod_InsertArray12345AtIndex5Of12345_CL1234512345()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            int[] insertNumbers = { 1, 2, 3, 4, 5 };
            bool expected = true;
            bool actual;
            //  Act
            customList.Insert(5, insertNumbers);
            actual = (customList.Equals(customListTwo));

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertMethod_InsertArray12345AtIndex0Of12345_CL1234512345()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            int[] insertNumbers = { 1, 2, 3, 4, 5 };
            bool expected = true;
            bool actual;
            //  Act
            customList.Insert(0, insertNumbers);
            actual = (customList.Equals(customListTwo));

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertMethod_InsertCL345678AtIndex2Of12910_CL1234512345678910()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 9, 10 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CustomList<int> insertNumbers = new CustomList<int>() { 3, 4, 5, 6, 7, 8 };
            bool expected = true;
            bool actual;
            //  Act
            customList.Insert(2, insertNumbers);
            actual = (customList.Equals(customListTwo));

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertMethod_InsertCL456AtIndex3Of123_CL123456()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3};
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4, 5, 6, };
            CustomList<int> insertNumbers = new CustomList<int>() { 4, 5, 6};
            bool expected = true;
            bool actual;
            //  Act
            customList.Insert(3, insertNumbers);
            actual = (customList.Equals(customListTwo));

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
