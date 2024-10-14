using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Calendar.Data
{
    internal class PostgreSQLContext: DbContext
    {
        protected readonly IConfiguration configuration;


        public PostgreSQLContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("Database"));
        }


        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
