using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miide
{
        public class outputmodel
        {
                [ColumnName("PredictedLabel")]
                public String Prediction { get; set; }
        }
}
