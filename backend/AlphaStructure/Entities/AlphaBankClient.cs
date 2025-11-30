using AlphaOfferService.AlphaStructure.Clients;

namespace AlphaOfferService.AlphaStructure.Entities
{
    public class AlphaBankClient : IClient
    {
        public string Id { get; set; } = null!;

        public float Age { get; set; }

        public Gender Gender { get; set; }
        
        public string AdminArea { get; set; } = string.Empty;
        
        public bool IsMoscowSpb { get; set; }
        
        public float PerCapitaIncomeRurAmt { get; set; }
        
        public float LogSalary6to12mAgg { get; set; }

        public bool IsSalaryKnown { get; set; }
        
        public float IncomeValue { get; set; }
        
        public float LogDpIlsAvgSalary1y { get; set; }
        
        public float SalaryVsRegion { get; set; }

        public float LogTurnOtherCrAvgActV2 { get; set; }
        
        public float LogTurnCurCrAvgActV2 { get; set; }
        
        public float LogTurnCurDbAvgActV2 { get; set; }
        
        public float LogTotalRurAmtCmAvg { get; set; }
        
        public float LogHdbBkiTotalMaxLimit { get; set; }
        
        public float CreditUtilization { get; set; }
        
        public float CrDbRatio { get; set; }
        
        public float HdbBkiTotalCnt { get; set; }
        
        public string LoanCntCategory { get; set; } = string.Empty;
        
        public bool HasCreditHistory { get; set; }

        public float SupermarketTransactionCategoryPercent { get; set; }

        public float RestaurantTransactionCategoryPercent { get; set; }

        public float AverageMonthlyTravelCategoryTransactionAmountOverYear { get; set; }
        
        public float EntertainmentRatio { get; set; }
        
        public float TransactionDiversity { get; set; }
        
        public float LogTurnSaveCrMaxV2 { get; set; }
        
        public float SavingsRatio { get; set; }

        public string DpEwbLastEmploymentPosition { get; set; } = string.Empty;
        
        public float DpIlsTotalSeniority { get; set; }
        
        public string SeniorityGroup { get; set; } = string.Empty;
        
        public float JobStability { get; set; }
        
        public int Month { get; set; }
        
        public int Quarter { get; set; }
        
        public bool IsYearEnd { get; set; }
        
        public string AgeGroup { get; set; } = string.Empty;
        
        public float Interaction { get; set; }
    }
}
