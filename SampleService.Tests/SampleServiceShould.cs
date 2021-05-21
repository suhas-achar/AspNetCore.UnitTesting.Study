using NUnit.Framework;

namespace SampleService.Tests
{
    public class SampleServiceShould
    {
        //  Please refer: https://blog.johnwu.cc/images/a/243.png

        public SampleServiceShould()
        {
            System.Console.WriteLine("Constructor");
        }

        [OneTimeSetUp]
        public void BeforeAll()
        {
            System.Console.WriteLine("OneTimeSetUp");
        }

        [SetUp]
        public void SetUp()
        {
            System.Console.WriteLine("Setup");
        }

        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("TearDown");
        }

        [Test]
        public void SquareTheInteger()
        {
            System.Console.WriteLine("SquareTheInteger");



            //  Arrange : Set the stage
            var service = new SampleService();

            //  Act : take the action
            var square = service.Square(10);

            //  Assert : test
            Assert.AreEqual(10*10, square);
        }

        [Test]
        public void ReturnMessage()
        {
            System.Console.WriteLine("ReturnMessage");


            //  Arrange : Set the stage
            var service = new SampleService();

            //  Act : take the action
            var message = service.GetMessage();

            //  Assert : test
            Assert.AreEqual("Good morning", message);
        }

        [OneTimeTearDown]
        public void AfterAll()
        {
            System.Console.WriteLine("OneTimeTearDown");
        }
    }
}