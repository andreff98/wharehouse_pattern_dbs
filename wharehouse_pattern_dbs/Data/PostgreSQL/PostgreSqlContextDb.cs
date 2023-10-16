using Microsoft.EntityFrameworkCore;
using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Data.PostgreSQL
{
    public class PostgreSqlContextDb : DbContext
    {
        public PostgreSqlContextDb() { }

        public PostgreSqlContextDb(DbContextOptions<PostgreSqlContextDb> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
