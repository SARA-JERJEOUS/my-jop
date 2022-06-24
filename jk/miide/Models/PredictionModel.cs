using DALco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miide.Models
{
        public class PredictionModel
        {
                public string DiseaseName { get; set; }
                public List<string> SymptomsList { get; set; }
               public List<drug> DrugsList { get; set; }
        }
}
