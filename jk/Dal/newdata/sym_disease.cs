using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.newdata
{
        public class sym_disease
        {
                public int id { get; set; }

                [ForeignKey(nameof(diseases))]
                public int diseaseId { get; set; }
                //navgation
                //lazyloding
                public virtual disease diseases { get; set; }

                [ForeignKey(nameof(symptom))]
                public int symptomesId { get; set; }
                //navgation
                //lazyloding
                public virtual symptomes symptom { get; set; }

        }
}
