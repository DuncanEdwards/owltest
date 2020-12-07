using System;
using System.Collections.Generic;
using System.Linq;

namespace SystemsUnderTest
{
    public class LetterCounter : ILetterCounter
    {
        public IEnumerable<(char, int)> GetLetterCounts(string sentence)
        {
            return (from letter in sentence
                    group letter by letter into g
                    select (g.Key, g.ToList().Count())).OrderByDescending(l => l.Item2);
        }
    }
}
