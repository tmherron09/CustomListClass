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
        // My first thought was redundant based on how Last<T>.Remove() calls IndexOf() once. However, if we didn't know that, like here not knowing how we'll implement, safe to check.
        [TestMethod]
        public void RemoveMethod_RemoveInt5FromCustomListOfFive5s_CountIs4()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();
            for (int i = 0; i <= 4; i++)
            {
                customList.Add(5);
            }
            int expected = 4;
            int actual;
            //  Act
            customList.Remove(5);
            actual = customList.Count;
            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Remove3FromListOf1Through5_IndexOf2Is4()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();
            for (int i = 1; i <= 5; i++)
            {
                customList.Add(i);
            }
            int expected = 4;
            int actual;
            //  Act
            customList.Remove(3);
            actual = customList[2];
            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Remove3FromListOf1Through5_ReturnTrue()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();
            for (int i = 1; i <= 5; i++)
            {
                customList.Add(i);
            }
            bool expected = true;
            bool actual;
            //  Act
            actual = customList.Remove(3); ;

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Remove8FromListOf1Through5_ReturnsFalse()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();
            for (int i = 1; i <= 5; i++)
            {
                customList.Add(i);
            }
            bool expected = false;
            bool actual;
            //  Act

            actual = customList.Remove(8);
            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveMethod_Remove8FromListOf1Through5_CountIs5()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();
            for (int i = 1; i <= 5; i++)
            {
                customList.Add(i);
            }
            int expected = 5;
            int actual;
            //  Act
            customList.Remove(8);
            actual = customList.Count;
            //  Assert
            Assert.AreEqual(expected, actual);
        }









    }
}
