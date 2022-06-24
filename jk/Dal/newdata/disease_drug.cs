using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.newdata
{
    public class disease_drug
    {
        public int id { get; set; }

        [ForeignKey(nameof(diseases))]
        public int diseaseId { get; set; }
        //navgation
        //lazyloding
        public virtual disease diseases { get; set; }

        [ForeignKey(nameof(drugs))]
        public int drugId { get; set; }
        //navgation
        //lazyloding
        public virtual drug drugs { get; set; }
    }
}
