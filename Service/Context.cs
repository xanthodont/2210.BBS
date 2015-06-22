using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Service
{
    public class Context : DbContext {
        public Context()
            : base("name=connStr") {
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<User>()
                .ToTable("User");
        }
    }
}
