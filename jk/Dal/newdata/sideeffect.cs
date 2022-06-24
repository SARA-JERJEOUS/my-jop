using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.newdata
{
    public class sideeffect
    {
        public int id { get; set; }

        public string description { get; set; }
        public string age { get; set; }
        public string Expiration_date { get; set; }

        public string When_to_consult__doctor { get; set; }
        public List<sideDrug> sideDrugs { get; set; } = new List<sideDrug>();

    }
}
