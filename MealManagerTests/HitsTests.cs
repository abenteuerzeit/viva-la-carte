using Moq;
using NUnit.Framework;
using VLC.Models.Recipes;

namespace VLC.Models.Recipes
{
    [TestFixture]
    public class HitsTests
    {
        private MockRepository mockRepository;



        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private Hits CreateHits()
        {
            return new Hits();
        }

        [Test]
        public void TestMethod1()
        {
            // Arrange
            var hits = this.CreateHits();

            // Act


            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}
