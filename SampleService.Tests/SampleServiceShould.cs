using NUnit.Framework;

namespace SampleService.Tests
{
    public class SampleServiceShould
    {
        [Test]
        [TestCase(680, true, 50_000, false)]
        [TestCase(710, true, 40_000, true)]
        [TestCase(700, true, 30_000, true)]
        [TestCase(700, false, 30_000, false)]
        public void SquareTheInteger(int creditScore, bool cityDweller, int monthlyIncome, bool approved)
        {
            //  Arrange : Set the stage
            var service = new SampleService();

            //  Act : take the action
            var result = service.IsApproved(creditScore, cityDweller, monthlyIncome);

            //  Assert : test
            Assert.AreEqual(approved, result);
        }
    }
}