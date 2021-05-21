using NUnit.Framework;

namespace SampleService.Tests
{
    public class SampleServiceShould
    {
        [Test]
        [TestCase(11)]
        [TestCase(-7)]
        [TestCase(145)]
        public void SquareTheInteger(int n)
        {
            //  Arrange : Set the stage
            var service = new SampleService();

            //  Act : take the action
            var square = service.Square(n);

            //  Assert : test
            Assert.AreEqual(n*n, square);
        }
    }
}