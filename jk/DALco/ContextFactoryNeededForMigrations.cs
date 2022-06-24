using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALco
{
        class ContextFactoryNeededForMigrations : IDesignTimeDbContextFactory<data_collection>
        {

                private const string ConnectionString =
         @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=datapharma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                public data_collection CreateDbContext(string[] args)
                {
                        var optionsBuilder = new DbContextOptionsBuilder<data_collection>();
                        optionsBuilder.UseSqlServer(ConnectionString);

                        return new data_collection(optionsBuilder.Options);
                }
        }
}
