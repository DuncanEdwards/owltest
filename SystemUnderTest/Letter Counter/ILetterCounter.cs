using System.Collections.Generic;

namespace SystemsUnderTest.Letter_Counter
{
    public interface ILetterCounter
    {
        public IEnumerable<(char, int)> GetLetterCounts(string sentence);
    }
}
