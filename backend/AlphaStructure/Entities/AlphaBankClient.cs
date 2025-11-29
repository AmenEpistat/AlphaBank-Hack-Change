using AlphaOfferService.AlphaStructure.Clients;

namespace AlphaOfferService.AlphaStructure.Entities
{
    public class AlphaBankClient : IClient
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

        public AlphaBankClient(
            string id,
            float age,
            Gender gender,
            float logSalary6to12,
            bool isSalaryKnow,
            float perCapitaIncomeInRegion,
            float logTurnOtherCrAvgAct,
            bool isNaTurnOtherCrAvgAct,
            float transactionCategorySupermarketPercentCnt,
            float logTransactionCategoryRestaurantsSumAmt,
            float logAvgByCategoryAmountSumCashflowcategoryName)
        {
            Id = id;
            Age = age;
            Gender = gender;
            LogSalary6to12 = logSalary6to12;
            IsSalaryKnow = isSalaryKnow;
            PerCapitaIncomeInRegion = perCapitaIncomeInRegion;
            LogTurnOtherCrAvgAct = logTurnOtherCrAvgAct;
            IsNaTurnOtherCrAvgAct = isNaTurnOtherCrAvgAct;
            TransactionCategorySupermarketPercentCnt = transactionCategorySupermarketPercentCnt;
            LogTransactionCategoryRestaurantsSumAmt = logTransactionCategoryRestaurantsSumAmt;
            LogAvgByCategoryAmountSumCashflowcategoryName = logAvgByCategoryAmountSumCashflowcategoryName;
        }
    }
}
