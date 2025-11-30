using AlphaOfferService.AlphaStructure.Clients;
using AlphaOfferService.Core;
using System.Runtime.InteropServices;

namespace AlphaOfferService.Models
{
    public class CatBoostModel : IIncomeModel
    {
        private readonly string _modelPath;

        private readonly IntPtr _modelHandle;

        public CatBoostModel(string modelPath)
        {
            _modelPath = modelPath;
            _modelHandle = ModelCalcerCreate();
            if (!LoadFullModelFromFile(_modelHandle, _modelPath))
                throw new Exception($"Произошла ошибка при создании модели: {GetErrorString()}");
        }

        public async Task<double> CalculateClientIncome(IClient client)
        {
            float[] floatFeatures =
            [
                client.Age,
                (float)client.Gender,
                client.IsMoscowSpb ? 1.0f : 0.0f,
                client.PerCapitaIncomeRurAmt,
                client.LogSalary6to12mAgg,
                client.IsSalaryKnown ? 1.0f : 0.0f,
                client.IncomeValue,
                client.LogDpIlsAvgSalary1y,
                client.SalaryVsRegion,
                client.LogTurnOtherCrAvgActV2,
                client.LogTurnCurCrAvgActV2,
                client.LogTurnCurDbAvgActV2,
                client.LogTotalRurAmtCmAvg,
                client.LogHdbBkiTotalMaxLimit,
                client.CreditUtilization,
                client.CrDbRatio,
                client.HdbBkiTotalCnt,
                client.HasCreditHistory ? 1.0f : 0.0f,
                client.SupermarketTransactionCategoryPercent,
                client.RestaurantTransactionCategoryPercent,
                client.AverageMonthlyTravelCategoryTransactionAmountOverYear,
                client.EntertainmentRatio,
                client.TransactionDiversity,
                client.LogTurnSaveCrMaxV2,
                client.SavingsRatio,
                client.DpIlsTotalSeniority,
                client.JobStability,
                client.Month,
                client.Quarter,
                client.IsYearEnd ? 1.0f : 0.0f,
                client.Interaction
            ];

            string[] catFeatures =
            [
                client.AdminArea,
                client.LoanCntCategory,
                client.DpEwbLastEmploymentPosition,
                client.SeniorityGroup,
                client.AgeGroup
            ];

            double[] results = new double[1];

            if (!CalcModelPredictionSingle(_modelHandle, floatFeatures, (ulong)floatFeatures.Length, catFeatures, (ulong)catFeatures.Length, results, 1))
                throw new Exception($"Произошла ошибка при вычислении дохода: {GetErrorString()}");

            return Math.Exp(results[0]) - 1;
        }

        [DllImport("catboostmodel", EntryPoint = "ModelCalcerCreate")]
        private static extern IntPtr ModelCalcerCreate();

        [DllImport("catboostmodel", EntryPoint = "GetErrorString")]
        private static extern string GetErrorString();

        [DllImport("catboostmodel", EntryPoint = "LoadFullModelFromFile")]
        private static extern bool LoadFullModelFromFile(IntPtr modelHandle, string fileName);

        [DllImport("catboostmodel")]
        private static extern bool CalcModelPredictionSingle(
            IntPtr modelHandle,
            float[] floatFeatures, ulong floatFeaturesSize,
            string[] catFeatures, ulong catFeaturesSize,
            double[] result, ulong resultSize
        );
    }
}
