using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.newdata
{
    public class role
    {
        public int id { get; set; }
        public int titel { get; set; }
        public string description { get; set; }

        public List<user> users { get; set; } = new List<user>();
    }
}
