﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListUnitTest
{
    [TestClass]
    public class ToStringOverrideTests
    {
        [TestMethod]
        public void ToStringMethod_AddItemGetString_EqualsOriginal()
        {
            //  Arrange
            CustomList<int> customList = new CustomList<int>();

            int word = 1;
            string expected = "1";
            string actual;
            //  Act
            customList.Add(word);
            actual = customList.ToString();

            //  Assert
            Assert.AreEqual(expected, actual);
        }
        
        



    }
}