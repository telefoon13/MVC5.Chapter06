﻿using System;
using EssentialTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestObject()
        {
            return new MinumumDiscountHelper();
        }


        [TestMethod]
        public void Discount_Above_100()
        {
            // arrange/act/assert (A/A/A) pattern

            //ARANGE
            IDiscountHelper target = getTestObject();
            decimal totaal = 200;

            //ACT
            var discountedTotal = target.ApplyDiscount(totaal);

            //ASSERT
            Assert.AreEqual(totaal * 0.9m, discountedTotal);
        }

        [TestMethod]
        public void Discount_Between_10_And_100()
        {
            //arrange
            IDiscountHelper target = getTestObject();

            // act
            decimal TenDollarDiscount = target.ApplyDiscount(10);
            decimal HundredDollarDiscount = target.ApplyDiscount(100);
            decimal FiftyDollarDiscount = target.ApplyDiscount(50);

            // assert
            Assert.AreEqual(5, TenDollarDiscount, "$10 discount is wrong");
            Assert.AreEqual(95, HundredDollarDiscount, "$100 discount is wrong");
            Assert.AreEqual(45, FiftyDollarDiscount, "$50 discount is wrong");
        }

        [TestMethod]
        public void Discount_Less_Than_10()
        {
            //arrange
            IDiscountHelper target = getTestObject();
            // act
            decimal discount5 = target.ApplyDiscount(5);
            decimal discount0 = target.ApplyDiscount(0);
            // assert
            Assert.AreEqual(5, discount5);
            Assert.AreEqual(0, discount0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Discount_Negative_Total()
        {
            //arrange
            IDiscountHelper target = getTestObject();
            // act
            target.ApplyDiscount(-1);
        }
    }
}
