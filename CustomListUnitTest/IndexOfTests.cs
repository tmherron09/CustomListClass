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
    public class IndexOfTests
    {

        [TestMethod]
        public void IndexOf_CustomList123GetIndexOf2_IndexOf1()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };

            int expected = 1;
            int actual;
            //  Act
            actual = customList.IndexOf(2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IndexOf_CustomList123GetIndexOf5_ReturnNegative1()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };

            int expected = -1;
            int actual;
            //  Act
            actual = customList.IndexOf(5);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IndexOf_CustomList123334GetIndexOf3_IndexOf2()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 ,3,3,4};

            int expected = 2;
            int actual;
            //  Act
            actual = customList.IndexOf(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IndexOf_CustomList1231IndexOf1StartIndex1_Index3()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 1 };

            int expected = 3;
            int actual;
            //  Act
            actual = customList.IndexOf(1, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IndexOf_CustomList12345IndexOf2StartIndex4_ReturnNegative1()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };

            int expected = -1;
            int actual;
            //  Act
            actual = customList.IndexOf(2, 4);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IndexOf_CL12345IndexOf2StartIndexNegative4_ReturnNegative1()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };

            int expected = -1;
            int actual;
            //  Act
            actual = customList.IndexOf(2, 4);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IndexOf_CL12345IndexOf2StartIndex7_ReturnNegative1()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };

            int expected = -1;
            int actual;
            //  Act
            actual = customList.IndexOf(2, 4);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IndexOf_CL1234512345IndexOf2StartIndex4Count4_Index6()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };

            int expected = 6;
            int actual;
            //  Act
            actual = customList.IndexOf(2, 4, 4);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IndexOf_CL1234512345IndexOf3StartIndex3Count4_ReturnNegative1()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };

            int expected = -1;
            int actual;
            //  Act
            actual = customList.IndexOf(3, 3, 4);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IndexOf_CL12345IndexOf3StartIndex2Count6_ReturnNegative1()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };

            int expected = -1;
            int actual;
            //  Act
            actual = customList.IndexOf(3, 2, 6);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
