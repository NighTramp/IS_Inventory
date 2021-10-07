using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IS_Inventory
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext() : base("IS_Inventory.Properties.Settings.DBIConnectionString") { }
    }
}
