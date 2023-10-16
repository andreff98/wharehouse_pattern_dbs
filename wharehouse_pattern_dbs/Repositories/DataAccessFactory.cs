using wharehouse_pattern_dbs.Repositories.PostgreSQL;
using wharehouse_pattern_dbs.Repositories.SQLServer;

namespace wharehouse_pattern_dbs.Repositories
{
    public class DataAccessFactory
    {
        public static IPostgreSqlRepository GetPostgreSqlRepository() => new PostgreSqlRepository();
        //public static ISqlServerRepository GetSqlServerRepository() => new SqlServerRepository();
    }
}
