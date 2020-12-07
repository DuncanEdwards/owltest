using System.Collections.Generic;

namespace SystemsUnderTest
{
    public interface ILetterCounter
    {
        public IEnumerable<(char, int)> GetLetterCounts(string sentence);
    }
}
