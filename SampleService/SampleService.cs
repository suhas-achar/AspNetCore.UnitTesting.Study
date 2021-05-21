using System;

namespace SampleService
{
    public class SampleService
    {
        public bool IsApproved(LoanApplication application)
        {
            return 
                application.CreditScore >= 700 
                && application.CityDweller 
                && application.MonthlyIncome >= 30_000;
        }
    }
}
