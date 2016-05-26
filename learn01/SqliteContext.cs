using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn01
{
    public class SqliteContext:DbContext
    {
        public SqliteContext():base(){}
        public SqliteContext(DbContextOptions<SqliteContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./learn01.db");
        }
        public DbSet<User> Users { get; set; }
    }
}