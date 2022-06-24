using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.newdata
{
    public class user
    {
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }

        [Required]
        public string email { get; set; }

        [ForeignKey(nameof(roles))]
        public int roleId { get; set; }
        //navgation
        //lazyloding
        public virtual role roles { get; set; }
    }
}
