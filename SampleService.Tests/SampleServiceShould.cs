using NUnit.Framework;

namespace SampleService.Tests
{
    public class SampleServiceShould
    {
        [Test]
        public void SquareTheInteger()
        {
            //  Arrange : Set the stage
            var service = new SampleService();

            //  Act : take the action
            var square = service.Square(10);

            //  Assert : test
            Assert.AreEqual(10*10, square);
        }
    }
}