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
    public class IteratorTests
    {
        [TestMethod]
        public void Iterate_IterateOverInt12345CustomListSumItems_Equals15()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);

            int expected = 15;
            int actual = 0;
            //  Act
            foreach (int number in customList)
            {
                actual += number;
            }
            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Iterate_IterateAndCompareToIndex_CorrectOrder()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);

            bool expected = true;
            bool actual = true;
            //  Act
            int index = 0;
            foreach (int number in customList)
            {
                if (customList[index] != number)
                {
                    actual = false;
                }
                index++;
            }
            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Iterate_IterateOverEmptyListAndSum_Equals0()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 0;
            int actual = 0;
            //  Act
            foreach (int number in customList)
            {
                actual += number;
            }
            //  Assert
            Assert.AreEqual(expected, actual);
        }
        // Test we can remove item in CustomList
        [TestMethod]
        public void Iterate_IterateCustomList12345AndRemoveWhereInt3_CustomList1245()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);

            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(4);
            expected.Add(5);

            CustomList<int> actual;
            //  Act
            actual = customList;
            foreach (int number in actual)
            {
                if (number == 3)
                {
                    actual.Remove(number);
                }
            }
            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Iterate_TestCurlyBracketInitializer_Equals15()
        {
            //  Arrange
            CustomList<int> initializer = new CustomList<int>() { 1, 2, 3, 4, 5 };

            CustomList<int> addMethod = new CustomList<int>();
            addMethod.Add(1);
            addMethod.Add(2);
            addMethod.Add(3);
            addMethod.Add(4);
            addMethod.Add(5);

            bool expected = true;
            bool actual;
            //  Act
            actual = addMethod.Equals(initializer);


            //  Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
