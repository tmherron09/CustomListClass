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
    public class CopyToTests
    {
        [TestMethod]
        public void CopyTo_CopyCL123ToNewArraySize3_ArrayEquals123()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };
            int[] expected = { 1, 2, 3 };
            int[] actual = new int[3];

            //  Act
            customList.CopyTo(actual, 0);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CopyTo_CopyCL123ToArrayOf5_ArrayEquals12345()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };
            int[] expected = { 1, 2, 3, 4, 5 };
            int[] actual = new int[5];
            actual[3] = 5;
            actual[4] = 5;
            //  Act
            customList.CopyTo(actual, 0);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CopyTo_CopyCL1234ToArrayMiddleOf12345678_Array12123478()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int[] expected = { 1, 2, 1, 2, 3, 4, 7, 8 };
            int[] actual = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //  Act
            customList.CopyTo(actual, 2);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CopyTo_CopyCL1234ToArray12At0_ArgumentException()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int[] array = { 1, 2 };

            //  Act
            customList.CopyTo(array, 0);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CopyTo_CopyCL1234ToArray12345At3_ArgumentException()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int[] array = { 1, 2, 3, 4, 5 };

            //  Act
            customList.CopyTo(array, 3);
        }
        [TestMethod]
        public void CopyTo_CLCopyCL12345At3ToArray1234At0_Array4534()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int[] expected = { 4, 5, 3, 4 };
            int[] actual = { 1, 2, 3, 4 };

            //  Act
            customList.CopyTo(3, actual, 0, 2);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CopyTo_CopyMiddleCL1234ToMiddleArray5678_Array5238()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int[] expected = { 5, 2, 3, 8 };
            int[] actual = { 5, 6, 7, 8 };

            //  Act
            customList.CopyTo(1, actual, 1, 2);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CopyTo_CopyCL1234ToNewArray_Array1234()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int[] expected = { 1,2,3,4};
            int[] actual = new int[4];

            //  Act
            customList.CopyTo(0, actual, 0, customList.Count);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CopyTo_CL1234At1ToArray123At2_ArgumentException()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int[] array = { 1, 2, 3 };

            //  Act
            customList.CopyTo(1, array, 2, 3);
        }
        [TestMethod]
        public void CopyTo_CopyCL1234ToMiddleOfNewArrayOf9_Array00123400()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int[] expected = { 0,0,1,2,3,4,0,0};
            int[] actual = new int[8];

            //  Act
            customList.CopyTo(0, actual, 2, customList.Count);

            //  Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
