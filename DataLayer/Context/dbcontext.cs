using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DataLayer.Entites;
using DataLayer.Context;
namespace DataLayer.Context {
    public class dbcontext : DbContext {
        public dbcontext (DbContextOptions<dbcontext> options) : base (options) {

        }

 public DbSet<Tbl_User> Tbl_Users { get; set; }
 public DbSet<Tran> Trans { get; set; }

    
}
        public class ToDoContextFactory : IDesignTimeDbContextFactory<dbcontext> {
            public dbcontext CreateDbContext (string[] args) {
                var builder = new DbContextOptionsBuilder<dbcontext> ();
                //   builder.UseSqlServer("Data Source=.;initial Catalog=monojobs;integrated Security=SSPI;MultipleActiveResultSets=true");
                builder.UseSqlServer ("Data Source=.;initial Catalog=Exercise_db;integrated Security=SSPI;MultipleActiveResultSets=true");
                return new dbcontext (builder.Options);
            }
        }

    }
