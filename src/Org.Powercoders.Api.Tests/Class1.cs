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

namespace Org.Powercoders.Api.Tests
{

    public class Class1
    {
        public void Test()
        {
            var t11 = new Token<int>();
            var t12 = new Token<int>();
            var evaluator1 = new Add<Token<int>, int>();
            var tresult1 = evaluator1.Evaluate(t11, t12);

            var t21 = new Token<long>() { Value = 5 };
            var t22 = new Token<long>() { Value = 1 };
            var evaluator2 = new Add<Token<long>, long>();
            var tresult2 = evaluator2.Evaluate(t21, t22);

            var expression = "2 + 2";

            // parse expression into two tokens and an operator

            var token1 = new Token<long>() {Value = 5};
            var token2 = new Token<long>() {Value = 1 };

            var addOperator = new AddOperator();
        }


        public double Sqrt(double value)
        {
            return Math.Sqrt(value);
        }

        public double Sin(double value)
        {
            return default(double);
        }
    }

    public class Functions<T>
    {
        public T Sqrt(T value)
        {
            return default(T);
        }

        public T Sin(T value)
        {
            return default(T);
        }
    }


    public interface IOperatorEvaluator2<TToken, TTokenType>
        where TToken : Token<TTokenType>
        where TTokenType : struct
    {
        TToken Evaluate(TToken token1, TToken token2);
    }

    public class Add<TToken, TTokenType> : IOperatorEvaluator2<TToken, TTokenType>
        where TToken : Token<TTokenType>
        where TTokenType : struct
    {
        public TToken Evaluate(TToken token1, TToken token2)
        {
            var value1 = token1.Value;
            throw new NotImplementedException();
        }
    }

    public class Token<T>
        where T : struct
    {
        public T Value { get; set; }
    }

    public class IntToken : Token<int>
    {
        
    }

    public class LongToken : Token<long>
    {

    }

    public class DoubleToken : Token<double>
    {

    }

    public enum OperatorEnum
    {
        Add = 0,
        Substract,
        Multiply,
        Divide
    }

    public class AddOperator : Operator
    {
        public AddOperator()
        {
            Value = OperatorEnum.Add;
        }
    }
    public class Operator
    {
        public OperatorEnum Value { get; set; }
    }
}
