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
    public class RemoveAtTests
    {
        [TestMethod]
        public void RemoveAtMethod_RemoveAt2OutOf12345_CL1245()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 4, 5 };

            bool expected = true;
            bool actual;

            //  Act
            customList.RemoveAt(2);
            actual = customList.Equals(customListTwo);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveAtMethod_RemoveAt0OutOf12345_CL2345()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 2,3, 4, 5 };

            bool expected = true;
            bool actual;

            //  Act
            customList.RemoveAt(0);
            actual = customList.Equals(customListTwo);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveAtMethod_RemoveAt4OutOf12345_CL1234()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4};

            bool expected = true;
            bool actual;

            //  Act
            customList.RemoveAt(4);
            actual = customList.Equals(customListTwo);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        // Good example, had to change an || to an &&, Yeah Tests!
        [TestMethod]
        public void RemoveAtMethod_RemoveAt5OutOf12345_NoChange()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4, 5 };

            bool expected = true;
            bool actual;

            //  Act
            customList.RemoveAt(5);
            actual = customList.Equals(customListTwo);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveAtMethod_RemoveAtNegative1OutOf12345_NoChange()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> customListTwo = new CustomList<int>() { 1, 2, 3, 4, 5 };

            bool expected = true;
            bool actual;

            //  Act
            customList.RemoveAt(5);
            actual = customList.Equals(customListTwo);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveAtMethod_RemoveAt0For3TimesInCountOf3_EndCount0()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };

            int expected = 0;
            int actual;

            //  Act
            customList.RemoveAt(0);
            customList.RemoveAt(0);
            customList.RemoveAt(0);

            actual = customList.Count;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveAtMethod_CapacityOf8RemoveAt0_Capacity8()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>(8) { 1, 2, 3,4,5,6,7,8 };

            int expected = 8;
            int actual;

            //  Act
            customList.RemoveAt(0);

            actual = customList.Capacity;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveAtMethod_CapacityOf8RemoveAt0All_Capacity8()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>(8) { 1, 2, 3, 4, 5, 6, 7, 8 };

            int expected = 0;
            int actual;

            //  Act
            // Can't use customList.Count as count decreases.
            for (int i = 0; i < 8; i++)
            {
                customList.RemoveAt(0);
            }

            actual = customList.Count;

            //  Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
