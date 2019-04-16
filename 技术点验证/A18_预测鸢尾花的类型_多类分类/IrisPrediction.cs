using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace 技术点验证
{
    /// <summary>
    /// 鸢尾花的预测结果
    /// </summary>
   public class IrisPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels;
    }
}
