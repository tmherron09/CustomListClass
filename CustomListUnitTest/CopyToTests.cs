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
            int[] expectedList = { 1, 2, 3 };
            int[] actualList = new int[3];
            bool expected = true;
            bool actual;
            //  Act
            customList.CopyTo(actualList, 0);
            actual = Enumerable.SequenceEqual(expectedList, actualList);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CopyTo_CopyCL123ToArrayOf5_ArrayEquals12345()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };
            int[] expectedList = { 1, 2, 3, 4, 5 };
            int[] actualList = new int[5];
            actualList[3] = 4;
            actualList[4] = 5;
            bool expected = true;
            bool actual;
            //  Act
            customList.CopyTo(actualList, 0);
            actual = Enumerable.SequenceEqual(expectedList, actualList);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CopyTo_CopyCL1234ToArrayMiddleOf12345678_Array12123478()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int[] expectedList = { 1, 2, 1, 2, 3, 4, 7, 8 };
            int[] actualList = { 1, 2, 3, 4, 5, 6, 7, 8 };
            bool expected = true;
            bool actual;
            //  Act
            customList.CopyTo(actualList, 2);
            actual = Enumerable.SequenceEqual(expectedList, actualList);

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
            int[] expectedList = { 4, 5, 3, 4 };
            int[] actualList = { 1, 2, 3, 4 };
            bool expected = true;
            bool actual;
            //  Act
            customList.CopyTo(3, actualList, 0, 2);
            actual = Enumerable.SequenceEqual(expectedList, actualList);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CopyTo_CopyMiddleCL1234ToMiddleArray5678_Array5238()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int[] expectedList = { 5, 2, 3, 8 };
            int[] actualList = { 5, 6, 7, 8 };
            bool expected = true;
            bool actual;
            //  Act
            customList.CopyTo(1, actualList, 1, 2);
            actual = Enumerable.SequenceEqual(expectedList, actualList);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CopyTo_CopyCL1234ToNewArray_Array1234()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
            int[] expectedList = { 1,2,3,4};
            int[] actualList = new int[4];
            bool expected = true;
            bool actual;
            //  Act
            customList.CopyTo(0, actualList, 0, customList.Count);
            actual = Enumerable.SequenceEqual(expectedList, actualList);

            //  Assertt
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
            int[] expectedList = { 0,0,1,2,3,4,0,0};
            int[] actualList = new int[8];
            bool expected = true;
            bool actual;
            //  Act
            customList.CopyTo(0, actualList, 2, customList.Count);
            actual = Enumerable.SequenceEqual(expectedList, actualList);

            //  Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
