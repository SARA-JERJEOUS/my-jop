using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace miide.Models
{
        public class model_user
        {
                [Required]
                public string username { get; set; }
                [Required]
                public string password { get; set; }
             
                //[Required]
                //public string email { get; set; }
        }
}
