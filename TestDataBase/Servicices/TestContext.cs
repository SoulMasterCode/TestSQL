using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TestDataBase.Models;

namespace TestDataBase.Servicices
{
    public class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Step> Steps { get; set; }
    }
}