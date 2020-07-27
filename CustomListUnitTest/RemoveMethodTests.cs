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
    public class RemoveMethodTests
    {
        [TestMethod]
        public void RemoveMethod_RemoveInt5FromCustomListOf1Through5_CountIs4()
        {
            //  Arrange
            CustomList<int>customList = new CustomList<int>();
            for(int i = 1; i <=5; i++)
            {
               customList.Add(i);
            }
            int expected = 4;
            int actual;
            //  Act
           customList.Remove(5);
            actual =customList.Count;
            //  Assert
            Assert.AreEqual(expected, actual);
        }
       













    }
}
