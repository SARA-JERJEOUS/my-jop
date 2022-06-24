using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.newdata
{
    public class drug
    {
        public int id { get; set; }
        public string trade_name { get; set; }
        public string Scientific_name { get; set; }
        public string company { get; set; }
        public string cost { get; set; }
        public string medicine_caliber { get; set; }
        public int package_size { get; set; }
        public int The_number_of_medicine { get; set; }
        public string description { get; set; }
        public string path_img { get; set; }
        public string how_to_use { get; set; }
        public List<disease_drug> disease_drugs { get; set; } = new List<disease_drug>();
        public List<sideDrug> sideDrugs { get; set; } = new List<sideDrug>();

    }
}
