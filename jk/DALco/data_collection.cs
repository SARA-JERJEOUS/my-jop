using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALco
{
    public class data_collection : DbContext
    {


        public data_collection(DbContextOptions<data_collection> options) : base(options)
        {

        }


        public DbSet<disease> diseases_table { get; set; }
        public DbSet<disease_drug> disease_drug_table { get; set; }
    
        public DbSet<user> user_table { get; set; }
        public DbSet<drug> drug_table { get; set; }
             

        }
}
