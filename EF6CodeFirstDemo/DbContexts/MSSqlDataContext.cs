using EF6CodeFirstDemo.ContextInitializer;
using System.Data.Entity;

namespace EF6CodeFirstDemo.DbContexts
{
    public class MSSqlDataContext : BaseDataContext
    {
        public MSSqlDataContext() : base("MSSqlDbContext") => Database.SetInitializer<MSSqlDataContext>(new MSSqlDataContextInitializer());
    }
}
