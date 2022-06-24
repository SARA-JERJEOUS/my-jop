using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.newdata
{
    public class data_collection : DbContext
    {
                public data_collection()
                {
                }

                public data_collection(DbContextOptions<data_collection> options) : base(options)
                              {

                              }

          


                public DbSet<disease> diseases_table { get; set; }
        public DbSet<drug> drug_table { get; set; }
        public DbSet<disease_drug> disease_drug_table { get; set; }
        public DbSet<sideeffect> sideeffect_table { get; set; }
        public DbSet<sideDrug> sideDrug_table { get; set; }
        public DbSet<user> user_table { get; set; }
        public DbSet<role> role_table { get; set; }
        public DbSet<sym_disease> sym_disease_table { get; set; }
        public DbSet<symptomes> symptomes_table { get; set; }
             

        }
}
