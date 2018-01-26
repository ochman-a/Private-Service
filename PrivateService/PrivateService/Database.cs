using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using ClientP;

namespace PrivateService
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Client.db");
        }

        public DbSet<Clients> Client
        {
            get;
            set;
        }
    }

    public class DatabaseContext2 : DbContext
    {
        public DatabaseContext2()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Service.db");
        }

        public DbSet<Clients> Client
        {
            get;
            set;
        }
    }
}
