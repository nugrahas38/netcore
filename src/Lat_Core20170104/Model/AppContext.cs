using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.Entity.Extensions;


namespace Lat_Core20170104.Model
{
    public class AppContext : DbContext
    {
        public DbSet<Buku> buku { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL(@"Server=127.0.0.1;Database=db_test;password=;user id=root");
        }
    }

}
