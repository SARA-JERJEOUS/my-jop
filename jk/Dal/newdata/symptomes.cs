using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.newdata
{
        public class symptomes
        {
                public int id { get; set; }
                public  string name_of_symptomes { get; set; }
                public List<sym_disease> symp_disease { get; set; } = new List<sym_disease>();








        }
}
