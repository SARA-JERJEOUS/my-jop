using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.newdata
{
    public class disease
    {
        public int id { get; set; }
        public string name_OF_disease { get; set; }
        public List<disease_drug> disease_drugs { get; set; } = new List<disease_drug>();
        public List<sym_disease> symp_disease { get; set; } = new List<sym_disease>();

        }
}
