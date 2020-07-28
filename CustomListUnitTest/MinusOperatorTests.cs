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
    public class MinusOperatorTests
    {

        [TestMethod]
        public void MinusOperator_CustomList135Minus216_CustomList35()
        {
            //  Arrange
            CustomList<int> minuend = new CustomList<int>();
            minuend.Add(1);
            minuend.Add(3);
            minuend.Add(5);
            
            CustomList<int> subtrahend = new CustomList<int>();
            subtrahend.Add(2);
            subtrahend.Add(1);
            subtrahend.Add(6);

            CustomList<int> expected = new CustomList<int>();
            expected.Add(3);
            expected.Add(5);
            CustomList<int> actual;

            //  Act
            actual = minuend - subtrahend;


            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_CustomList11111Minus1_CustomList1111()
        {
            //  Arrange
            CustomList<int> minuend = new CustomList<int>();
            minuend.Add(1);
            minuend.Add(1);
            minuend.Add(1);
            minuend.Add(1);
            minuend.Add(1);

            CustomList<int> subtrahend = new CustomList<int>();
            subtrahend.Add(1);

            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(1);
            expected.Add(1);
            expected.Add(1);
            CustomList<int> actual;

            //  Act
            actual = minuend - subtrahend;


            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_EmptyMinusNotEmpty_ResultEmptyList()
        {
            //  Arrange
            CustomList<int> minuend = new CustomList<int>();

            CustomList<int> subtrahend = new CustomList<int>();
            subtrahend.Add(1);
            subtrahend.Add(2);
            subtrahend.Add(3);

            CustomList<int> expected = new CustomList<int>();

            CustomList<int> actual;

            //  Act
            actual = minuend - subtrahend;


            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_NotEmptyMinusEmpty_ResultNoChange()
        {
            //  Arrange
            CustomList<int> minuend = new CustomList<int>();
            minuend.Add(1);
            minuend.Add(2);
            minuend.Add(3);

            CustomList<int> subtrahend = new CustomList<int>();
            
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);

            CustomList<int> actual;

            //  Act
            actual = minuend - subtrahend;


            //  Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_SubtractedFromSelf_EmptyList()
        {
            //  Arrange
            CustomList<int> minuend = new CustomList<int>();
            minuend.Add(1);
            minuend.Add(2);
            minuend.Add(3);

            CustomList<int> expected = new CustomList<int>();
            

            CustomList<int> actual;

            //  Act
            actual = minuend - minuend;


            //  Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
