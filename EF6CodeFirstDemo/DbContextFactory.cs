using EF6CodeFirstDemo.DbContexts;
using System;

namespace EF6CodeFirstDemo
{
    public class DbContextFactory
    {
        public BaseDataContext ResolveDbContext(DbTypes dbTypes = DbTypes.MSSql)
        {
            switch (dbTypes)
            {
                case DbTypes.MSSql:
                    return new MSSqlDataContext();
                case DbTypes.MySql:
                    return new MySqlDataContext();
                case DbTypes.Oracle:
                default:
                    throw new NotImplementedException();
            }
        }
    }

    public enum DbTypes
    {
        MSSql = 1,
        MySql = 2,
        Oracle = 3
    }
}
