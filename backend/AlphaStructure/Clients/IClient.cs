namespace AlphaOfferService.AlphaStructure.Clients
{
    public interface IClient
    {
        public string Id { get; }

        public float Age { get; }

        public Gender Gender { get; }

        public float LogSalary6to12 { get; }

        public bool IsSalaryKnow { get; }

        public float PerCapitaIncomeInRegion { get; }

        public float LogTurnOtherCrAvgAct { get; }

        public bool IsNaTurnOtherCrAvgAct { get; }

        public float TransactionCategorySupermarketPercentCnt { get; }

        public float LogTransactionCategoryRestaurantsSumAmt { get; }

        public float LogAvgByCategoryAmountSumCashflowcategoryName { get; }
    }
}
