using System;
using System.Data.Entity;

namespace SQL_Entity_Framework
{
    public class MyDbContext:DbContext
    {
        public MyDbContext():base("DBConnectionString")
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Song>Songs{ get; set; }

    }
}
