using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DALco
{
    public class user
    { 
         [Key]
        public int id { get; set; }
        [Required]
      
        public string username { get; set; }
        [Required]
        public string password { get; set; }

        [Required]
        public string email { get; set; }

  
    }
}
