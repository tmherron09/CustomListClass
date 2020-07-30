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
    public class ShiftItemsTests
    {
        [TestMethod]
        public void ShiftItemsMethod_Shift12345AtIndex2Amount1_CL123345()
        {
            //  Arrange
            CustomList<int> customeList = new CustomList<int>(8) { 1, 2, 3, 4, 5 };
            CustomList<int> customeListTwo = new CustomList<int>(8) { 1, 2, 3,3, 4, 5 };

            bool expected = true;
            bool actual;

            //  Act
            customeList.ShiftItems(2, 1);
            actual = customeList.Equals(customeListTwo);

            //  Assert
            Assert.AreEqual(expected, actual);

        }





    }
}
