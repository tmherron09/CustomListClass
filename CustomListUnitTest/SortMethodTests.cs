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
    public class SortMethodTests
    {
        [TestMethod]
        public void QuickSort_Jumbled0Through10_AscendingOrder()
        {
            // Arrange
            CustomList<int> jumble = new CustomList<int>() { 9, 4, 6, 2, 7, 5, 0, 10, 1, 3, 8 };

            CustomList<int> expected = new CustomList<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CustomList<int> actual = jumble;

            // Act
            actual.Sort();

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void QuickSort_RandomStrings_AlpabeticalOrder()
        {
            // Arrange
            CustomList<string> jumble = new CustomList<string>() { "Hello", "Apple", "Cat", "Zoo", "Bunny" };

            CustomList<string> expected = new CustomList<string>() { "Apple", "Bunny", "Cat", "Hello", "Zoo" };
            CustomList<string> actual = jumble;

            // Act
            actual.Sort();

            //  Assert
            Assert.AreEqual(expected, actual);
        }



    }
}
