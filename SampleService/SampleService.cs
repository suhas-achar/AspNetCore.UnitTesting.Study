using System;

namespace SampleService
{
    public class SampleService
    {
        public bool IsApproved(int creditScore, bool cityDweller, int monthlyIncome)
        {
            return creditScore >= 700 && cityDweller && monthlyIncome >= 30_000;
        }
    }
}
