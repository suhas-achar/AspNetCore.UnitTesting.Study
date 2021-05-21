using NUnit.Framework;
using System.Collections.Generic;

namespace SampleService.Tests
{
    public class SampleServiceShould
    {

        public static IEnumerable<LoanApplicationWrapper> GetWrappers()
        {
            yield return new LoanApplicationWrapper
            {
                Application = new LoanApplication(680, true, 50_000),
                IsApproved = false
            };

            yield return new LoanApplicationWrapper
            {
                Application = new LoanApplication(710, true, 40_000),
                IsApproved = true
            };

            yield return new LoanApplicationWrapper
            {
                Application = new LoanApplication(700, true, 30_000),
                IsApproved = true
            };

            yield return new LoanApplicationWrapper
            {
                Application = new LoanApplication(700, false, 30_000),
                IsApproved = false
            };
        }

        [Test]
        [TestCaseSource("GetWrappers")]

        //[Test, TestCaseSource("GetWrappers")] //  also possible
        public void SquareTheInteger(LoanApplicationWrapper wrapper)
        {
            //  Arrange : Set the stage
            var service = new SampleService();

            //  Act : take the action
            var result = service.IsApproved(wrapper.Application);

            //  Assert : test
            Assert.AreEqual(wrapper.IsApproved, result);
        }
    }
}