using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.Powercoders.Api.Calculator;

namespace Org.Powercoders.Api.Tests.Calculator
{
    [TestClass]
    public class StandardCalculatorTest
    {
        private const string VALID_EXPRESSION = " 2     + 2       ";
        private const string INVALID_EXPRESSION = " 2     ++ 2       ";

        [TestMethod]
        public void InstantiatingCalculatorSucceeds()
        {
            var sut = new StandardCalculator();

            Assert.IsNotNull(sut);
        }


        [TestMethod]
        public void InvokingCalculatorIsValidExpressionWithNullExpressionThrowsContractException()
        {
            var sut = new StandardCalculator();

            Assert.IsNotNull(sut);

            sut.IsValidExpression(null);
        }

        [TestMethod]
        public void InvokingCalculatorIsValidExpressionWithValidExpressionReturnsTrue()
        {
            var sut = new StandardCalculator();

            Assert.IsNotNull(sut);

            var result = sut.IsValidExpression(VALID_EXPRESSION);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvokingCalculatorIsValidExpressionWithInvalidExpressionReturnsFalse()
        {
            var sut = new StandardCalculator();

            Assert.IsNotNull(sut);

            var result = sut.IsValidExpression(INVALID_EXPRESSION);
            Assert.IsFalse(result);
        }
    }
} 
