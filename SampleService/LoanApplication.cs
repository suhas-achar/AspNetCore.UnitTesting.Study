using System;
using System.Collections.Generic;
using System.Text;

namespace SampleService
{
    public class LoanApplication
    {
        public int CreditScore { get; }
        public bool CityDweller { get; }
        public int MonthlyIncome { get; }

        public LoanApplication(int creditScore, bool cityDweller, int monthlyIncome)
        {
            CreditScore = creditScore;
            CityDweller = cityDweller;
            MonthlyIncome = monthlyIncome;
        }
    }
}
