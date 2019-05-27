using EF6CodeFirstDemo.ContextInitializer;
using System.Data.Entity;

namespace EF6CodeFirstDemo.DbContexts
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class MySqlDataContext : BaseDataContext
    {
        public MySqlDataContext() : base("MySqlDbContext") => Database.SetInitializer<MySqlDataContext>(new MySqlDataContextInitializer());

    }
}
