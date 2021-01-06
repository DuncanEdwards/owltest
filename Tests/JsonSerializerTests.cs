using NUnit.Framework;
using System.Collections.Generic;
using SystemsUnderTest;
using SystemsUnderTest.JsonSerializer;
using SystemsUnderTest.JsonSerializer.Models;

namespace Tests
{
    public class JsonSerializerTests
    {
        [Test]
        public void WhenBookObjectIsSerialized_ThenReturnedStringIsAsExpected()
        {
            // Arrange.
            var bookObject = new Book
            {
                Title = "The Big Book of CSharp",
                Authors = new List<string>
                {
                    "Terry",
                    "Duncan",
                    "Anthony",
                    "Kes"
                }
            };

            var jsonSerializer = new JsonSerializer();

            // Act.
            var objectAsString = jsonSerializer.Serialize(bookObject);

            // Assert.
            Assert.That(objectAsString, Is.EqualTo("{\"Title\":\"The Big Book of CSharp\",\"Authors\":[\"Terry\",\"Duncan\",\"Anthony\",\"Kes\"]}"));
        }
    }
}
