using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.Powercoders.Api.Calculator;

namespace Org.Powercoders.Api.Tests.Calculator
{
    [TestClass]
    public class ScientificCalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }



        [TestMethod]
        public void InvokingScientificCalculatorIsValidExpressionWithNullExpressionThrowsContractException()
        {
            var sut = new ScientificCalculator();

            var result = sut.IsValidExpression(default(string));
        }


        [TestMethod]
        public void InvokingScientificCalculatorIsValidExpressionWithValidExpressionShouldReturnTrue()
        {
            var sut = new ScientificCalculator();

            var result = sut.IsValidExpression(" sqrt  (   9   )    ");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvokingScientificCalculatorIsValidExpressionWithInValidExpressionShouldReturnfalse()
        {
            var sut = new ScientificCalculator();

            var result = sut.IsValidExpression(" sqrt  (   9   )    bc");

            Assert.IsFalse(result);
        }
    }
}
