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


    public abstract class OperatorEvaluator<TOperator, T1, T2, TResult>
        where TOperator : Operator
        where T1 : Token
        where T2 : Token
        where TResult : Token
    {
        public abstract TResult Evaluate(T1 value1, T2 value2);
    }

    public class Add<T1, T2, TResult> : OperatorEvaluator<AddOperator, T1, T2, TResult>
        where T1 : Token
        where T2 : Token
        where TResult : Token
    {
        public override TResult Evaluate(T1 value1, T2 value2)
        {
            throw new NotImplementedException();
        }
    }

    public class Token
    {
        public object Value { get; set; }
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
