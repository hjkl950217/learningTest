using Microsoft.ML;
using Microsoft.ML.Transforms;
using System;
using Verification.Core;

namespace 技术点验证
{
    //需要 Microsoft.ML
    //可以根据花瓣长度等特征预测鸢尾花的类型
    //(Iris Setosa(山鸢尾)、Iris Versicolour(杂色鸢尾),Iris Virginica(维吉尼亚鸢尾))

    /*
     * 简书文档1：http://blog.lisp4fun.com/2018/03/03/decision-tree
     * 
     * 微软文档1：https://dotnet.microsoft.com/learn/machinelearning-ai/ml-dotnet-get-started-tutorial/intro
     * 微软文档2：https://dotnet.microsoft.com/learn/machinelearning-ai/ml-dotnet-get-started-tutorial/code
     */

    public class A18_预测鸢尾花的类型_多类分类 : IVerification
    {
        public VerificationTypeEnum VerificationType => VerificationTypeEnum.A18_预测鸢尾花的类型_多类分类;

        public const string dataBaseAddr = @"A18_情感分析分类\data";
        public const string _dataPath = dataBaseAddr + @"\iris.txt";

        public void Start(string[] args)
        {
            //创建ML上下文
            MLContext mlContext = new MLContext();

            //加载数据
            IDataView trainingDataView = mlContext.Data.LoadFromTextFile<IrisData>(
                path: _dataPath,
                hasHeader: false,
                separatorChar: ',');

            #region 转换数据并添加学习者--构建模型

            //获取处理管道的第一个节点-值转键估计器
            ValueToKeyMappingEstimator estimator = mlContext.Transforms.Conversion.MapValueToKey("Label");

            //添加转换估计器
            var columnConcatenatingEstimator = mlContext.Transforms.Concatenate("Features", "SepalLength", "SepalWidth", "PetalLength", "PetalWidth");
            estimator.Append(columnConcatenatingEstimator);

            //添加检查点
            //后续处理节点将会使用检查点的数据格式
            estimator.AppendCacheCheckpoint(mlContext);

            //添加最大熵估计器
            var maxEntropyEstimator = mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy(
                labelColumnName: "Label",
                featureColumnName: "Features");
            estimator.Append(maxEntropyEstimator);

            //添加键转值估计器
            var kToVEstimator = mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel");
            var pipeline = estimator.Append(kToVEstimator);

            #endregion 转换数据并添加学习者--构建模型

            //训练模型
            var model = pipeline.Fit(trainingDataView);

            //预测类型
            var predictionEngine = mlContext.Model.CreatePredictionEngine<IrisData, IrisPrediction>(model);
            var prediction = predictionEngine.Predict(new IrisData()
            {
                SepalLength = 3.3f,
                SepalWidth = 1.6f,
                PetalLength = 0.2f,
                PetalWidth = 5.1f,
            });

            Console.WriteLine($"预测结果：{prediction.ToJson()}"); ; //这个方法需要迁移到验证库中
        }
    }
}