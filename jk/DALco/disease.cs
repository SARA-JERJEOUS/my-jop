using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DALco
{
    public class disease
    {
        public int id { get; set; }
                [Required]
                public string name_OF_disease { get; set; }
        public List<disease_drug> disease_drugs { get; set; } = new List<disease_drug>();

        }
}
