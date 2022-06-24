using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consolee
{
        public class outputmodel
        {
                [ColumnName("PredictedLabel")]
                public String Prediction { get; set; }
        }
}
