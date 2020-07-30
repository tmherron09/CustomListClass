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
    public class ClearTests
    {
        [TestMethod]
        public void ClearMethod_ClearCLOf12345_EmptyCL()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };

            int expected = 0;
            int actual;

            //  Act
            customList.Clear();
            actual = customList.Count;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ClearMethod_ClearCLOf12345_CapacityUnChanged()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4, 5 };

            int expected = customList.Capacity;
            int actual;

            //  Act
            customList.Clear();
            actual = customList.Capacity;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        

    }
}
