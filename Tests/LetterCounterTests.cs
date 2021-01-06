using NUnit.Framework;
using SystemsUnderTest;
using SystemsUnderTest.Letter_Counter;

namespace Tests
{
    public class LetterCounterTests
    {
        [Test]
        public void TestLetterCounter_BasicWord()
        {
            // Arrange.
            var letterCounter = new LetterCounter();

            // Act.
            var result = letterCounter.GetLetterCounts("hello");

            // Assert.
        }

        [Test]
        public void TestLetterCounter_NullValues()
        {
            // Arrange.
            var letterCounter = new LetterCounter();

            // Act.
            var result = letterCounter.GetLetterCounts(null);

            // Assert.
        }

        [Test]
        public void TestLetterCounter_LongerSentence()
        {
            // Arrange.
            var letterCounter = new LetterCounter();

            // Act.
            var result = letterCounter.GetLetterCounts("the quick brown fox jumps over the lazy dog.");

            // Assert.
        }
    }
}