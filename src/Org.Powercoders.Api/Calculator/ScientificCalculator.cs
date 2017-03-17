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

using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace Org.Powercoders.Api.Calculator
{
    public class ScientificCalculator : ICalculator
    {
        public bool IsValidExpression(string expression)
        {
            Contract.Assert(!string.IsNullOrWhiteSpace(expression));

            Regex regex = new Regex(@"^\ *(sqrt)\ *(\()\ *(\d+)\ *(\))\ *$");

            var match = regex.IsMatch(expression);

            return match;
        }

        public float GetSqurtResult(string expression)
        {
            Regex regex = new Regex(@"^\ *(sqrt)\ *(\()\ *(\d+)\ *(\))\ *$");
            Match match = regex.Match(expression);

            var value = match.Value;



            return default(float);
        }
    }
}
