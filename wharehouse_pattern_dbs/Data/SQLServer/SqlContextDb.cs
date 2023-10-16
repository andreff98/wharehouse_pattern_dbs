using Microsoft.EntityFrameworkCore;
using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Data.SQLServer
{
    public class SqlContextDb : DbContext
    {
        public SqlContextDb() { }

        public SqlContextDb(DbContextOptions<SqlContextDb> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }

    }
}
