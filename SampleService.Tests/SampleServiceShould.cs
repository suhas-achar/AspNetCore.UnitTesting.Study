using NUnit.Framework;

namespace SampleService.Tests
{
    public class SampleServiceShould
    {
        private SampleService service;

        [SetUp]
        public void SetUp()
        {
            //  to avoid side-effects (from retained state in the object)
            this.service = new SampleService();
        }

        [Test]
        public void SquareTheInteger()
        {
            var square = service.Square(10);

            Assert.AreEqual(10*10, square);
        }

        [Test]
        public void ReturnMessage()
        {
            var message = service.GetMessage();

            Assert.AreEqual("Good morning", message);
        }
    }
}