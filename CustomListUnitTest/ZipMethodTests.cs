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
    public class ZipMethodTests
    {
        [TestMethod]
        public void ZipMethod_ZipCustomList135CustomList246_CustomList123456()
        {
            //  Arrange
            CustomList<int> odd = new CustomList<int> { 1, 3, 5 };
            CustomList<int> even = new CustomList<int> { 2, 4, 6 };

            CustomList<int> expected = new CustomList<int> { 1, 2, 3, 4, 5, 6 };
            CustomList<int> actual;
            //  Act
            actual = odd.Zip(even);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_ZipLong135678WithShort24_CustomList12345678()
        {
            //  Arrange
            CustomList<int> longList = new CustomList<int> { 1, 3, 5, 6, 7, 8 };
            CustomList<int> shortList = new CustomList<int> { 2, 4 };

            CustomList<int> expected = new CustomList<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            CustomList<int> actual;
            //  Act
            actual = longList.Zip(shortList);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_ZipShort13WithLong245678_CustomList12345678()
        {
            //  Arrange
            CustomList<int> shortList = new CustomList<int> { 1, 3 };
            CustomList<int> longList = new CustomList<int> { 2, 4, 5, 6, 7, 8 };

            CustomList<int> expected = new CustomList<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            CustomList<int> actual;
            //  Act
            actual = shortList.Zip(longList);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_ZipEmptyWith123_CustomList123()
        {
            //  Arrange
            CustomList<int> empty = new CustomList<int>();
            CustomList<int> notEmpty = new CustomList<int> { 1, 2, 3 };

            CustomList<int> expected = new CustomList<int> { 1, 2, 3 };
            CustomList<int> actual;
            //  Act
            actual = empty.Zip(notEmpty);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_Zip123WithEmpty_CustomList123()
        {
            //  Arrange
            CustomList<int> notEmpty = new CustomList<int> { 1, 2, 3 };
            CustomList<int> empty = new CustomList<int>();

            CustomList<int> expected = new CustomList<int> { 1, 2, 3 };
            CustomList<int> actual;
            //  Act
            actual = notEmpty.Zip(empty);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_ZipEmptyWithEmpty_EmptyCustomList()
        {
            //  Arrange
            CustomList<int> notEmpty = new CustomList<int> { 1, 2, 3 };
            CustomList<int> empty = new CustomList<int>();

            CustomList<int> expected = new CustomList<int> { 1, 2, 3 };
            CustomList<int> actual;
            //  Act
            actual = notEmpty.Zip(empty);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipMethod_ZipCustomListWithItSelf_EachItemDuplicated()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int> { 1, 2, 3 };
            

            CustomList<int> expected = new CustomList<int> { 1, 1, 2, 2, 3, 3 };
            CustomList<int> actual;
            //  Act
            actual = customList.Zip(customList);

            //  Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
