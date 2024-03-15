using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharacter.Tests
{
    public static class ConterLetterCaseGenerator
    {
        public static IEnumerable<object[]> GetCases()
        {
            yield return [GetJustOneWordTestCase()];
        }

        private static CountLettersCase GetJustOneWordTestCase()
        {
            return new CountLettersCase
            {
                Input = "Roberto",
                ExpectedDictionary = new Dictionary<char, int>
                {
                    ['r'] = 2,
                    ['o'] = 2,
                    ['b'] = 1,
                    ['e'] = 1,
                    ['t'] = 1,
                }
            };
        }
    }

}
