using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DALco
{
    public class drug
    {
                [Key]
               public int id { get; set; }
                [Required]
                public string trade_name { get; set; }
                [Required]
                public string Scientific_name { get; set; }
            
                [Required]
                public string cost { get; set; }
                [Required]
                public string medicine_caliber { get; set; }
                [Required]
                public int package_size { get; set; }
                [Required]
                public int The_number_of_medicine { get; set; }
                [Required]
                public string description { get; set; }
              //  [Required]
              //  public byte[]  path_img { get; set; }
                [Required]
                public string how_to_use { get; set; }
        public List<disease_drug> disease_drugs { get; set; } = new List<disease_drug>();

    }
}
