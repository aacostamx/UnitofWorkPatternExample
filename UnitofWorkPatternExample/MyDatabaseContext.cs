using System.Data.Entity;

namespace UnitofWorkPatternExample
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("name=MyDatabaseConnectionString") { }
    }
}