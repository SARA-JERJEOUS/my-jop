using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.newdata
{
    public class sideDrug
    {
        public int id { get; set; }
        [ForeignKey(nameof(sideeffects))]
        public int sideeffectId { get; set; }
        //navgation
        //lazyloding
        public virtual sideeffect sideeffects { get; set; }

        [ForeignKey(nameof(drugs))]
        public int drugId { get; set; }
        //navgation
        //lazyloding
        public virtual drug drugs { get; set; }


    }
}
