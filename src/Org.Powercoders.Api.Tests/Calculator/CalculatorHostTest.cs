/**
 * Copyright 2017 d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biz.dfch.CS.Testing.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.Powercoders.Api.Calculator;

namespace Org.Powercoders.Api.Tests.Calculator
{
    [TestClass]
    public class CalculatorHostTest
    {
        public static bool IsCalculatorInstantiated = false;

        public class TestCalculator : ICalculator
        {
            public const string VALID_EXPRESSION = "VALID_EXPRESSION";
            public const string INVALID_EXPRESSION = "INVALID_EXPRESSION";

            public TestCalculator()
            {
                IsCalculatorInstantiated = true;
            }

            public bool IsValidExpression(string expression)
            {
                return expression == VALID_EXPRESSION;
            }
        }

        [ExpectContractFailure(MessagePattern = "calculator")]
        [TestMethod]
        public void InstantiatingCalculatorHostWithNullCalculatorThrowsContractException()
        {
            var sut = new CalculatorHost(default(ICalculator));
        }

        [TestMethod]
        public void InstantiatingCalculatorHostSucceeds()
        {
            IsCalculatorInstantiated = false;
            var calculator = new TestCalculator();

            var sut = new CalculatorHost(calculator);

            Assert.IsNotNull(sut);
            Assert.IsTrue(IsCalculatorInstantiated);
        }

        [ExpectContractFailure(MessagePattern = "expression")]
        [TestMethod]
        public void InvokingCalculatorHostIsValidExpressionWithNullExpressionThrowsContractException()
        {
            IsCalculatorInstantiated = false;
            var calculator = new TestCalculator();

            var sut = new CalculatorHost(calculator);
            Assert.IsNotNull(sut);
            Assert.IsTrue(IsCalculatorInstantiated);

            var result = sut.IsValidExpression(default(string));
        }

        [TestMethod]
        public void InvokingCalculatorHostIsValidExpressionWithValidExpressionShouldReturnTrue()
        {
            IsCalculatorInstantiated = false;
            var calculator = new TestCalculator();

            var sut = new CalculatorHost(calculator);
            Assert.IsNotNull(sut);
            Assert.IsTrue(IsCalculatorInstantiated);

            var result = sut.IsValidExpression(TestCalculator.VALID_EXPRESSION);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvokingCalculatorHostIsValidExpressionWithInvalidExpressionShouldReturnFalse()
        {
            IsCalculatorInstantiated = false;
            var calculator = new TestCalculator();

            var sut = new CalculatorHost(calculator);
            Assert.IsNotNull(sut);
            Assert.IsTrue(IsCalculatorInstantiated);

            var result = sut.IsValidExpression(TestCalculator.INVALID_EXPRESSION);
            Assert.IsFalse(result);
        }
    }
}
