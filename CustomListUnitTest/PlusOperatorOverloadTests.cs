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
    public class PlusOperatorOverloadTests
    {

        [TestMethod]
        public void PlusOperator_AddCustomList135ToCustomList246_CustomListOf135246()
        {
            //  Arrange
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);

            CustomList<int> expectedSum = new CustomList<int>();
            expectedSum.Add(1);
            expectedSum.Add(3);
            expectedSum.Add(5);
            expectedSum.Add(2);
            expectedSum.Add(4);
            expectedSum.Add(6);
            bool hasPassed = true;

            CustomList<int> actualSum;

            // Act
            actualSum = odd + even;

            if (expectedSum.Count != actualSum.Count)
            {
                hasPassed = false;
            }

            for (int i = 0; i < expectedSum.Count; i++)
            {
                if (expectedSum[i] != actualSum[i])
                {
                    hasPassed = false;
                }
            }


            // Assert
            Assert.IsTrue(hasPassed);
        }
        [TestMethod]
        public void PlusOperator_AddCustomList135ToCustomList246_EqualsCustomListOf135246()
        {
            //  Arrange
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);

            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(3);
            expected.Add(5);
            expected.Add(2);
            expected.Add(4);
            expected.Add(6);
            CustomList<int> actual;

            // Act
            actual = odd + even;
            

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
