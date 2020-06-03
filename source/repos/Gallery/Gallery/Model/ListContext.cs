using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Model {
    public class ListContext : DbContext {
        private const string CONNECTION_STRING = "Data Source=LAPTOP-60VG75ST\\SQLEXPRESS;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DbSet<GroceriesItem> Groceries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
    }
}
