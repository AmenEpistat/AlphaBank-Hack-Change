namespace AlphaOfferService.AlphaStructure.Clients
{
    public interface IClient
    {
        public string Id { get; }

        public float Age { get; }

        public Gender Gender { get; }

        public string AdminArea { get; }

        public bool IsMoscowSpb { get; }

        public float PerCapitaIncomeRurAmt { get; }

        public float LogSalary6to12mAgg { get; }

        public bool IsSalaryKnown { get; }

        public float IncomeValue { get; }

        public float LogDpIlsAvgSalary1y { get; }

        public float SalaryVsRegion { get; }

        public float LogTurnOtherCrAvgActV2 { get; }

        public float LogTurnCurCrAvgActV2 { get; }

        public float LogTurnCurDbAvgActV2 { get; }

        public float LogTotalRurAmtCmAvg { get; }

        public float LogHdbBkiTotalMaxLimit { get; }

        public float CreditUtilization { get; }

        public float CrDbRatio { get; }

        public float HdbBkiTotalCnt { get; }

        public string LoanCntCategory { get; }

        public bool HasCreditHistory { get; }

        public float SupermarketTransactionCategoryPercent { get; }

        public float RestaurantTransactionCategoryPercent { get; }

        public float AverageMonthlyTravelCategoryTransactionAmountOverYear { get; }

        public float EntertainmentRatio { get; }

        public float TransactionDiversity { get; }

        public float LogTurnSaveCrMaxV2 { get; }

        public float SavingsRatio { get; }

        public string DpEwbLastEmploymentPosition { get; }

        public float DpIlsTotalSeniority { get; }

        public string SeniorityGroup { get; }

        public float JobStability { get; }

        public int Month { get; }

        public int Quarter { get; }

        public bool IsYearEnd { get; }

        public string AgeGroup { get; }

        public float Interaction { get; }
    }
}
