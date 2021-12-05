using DataAccess.Concrete.EntityFramework.Mapping;
using Entities.Concrete.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions <Context> options) : base(options) 
        {

        }
        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = "Data Source =.\\SQLEXPRESS; Initial Catalog = ECommenrceProjectWithWebAPIDb; Integrated Security = True";
            optionsBuilder.UseSqlServer(connString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public virtual DbSet<User> Users { get; set; } 
    }
}
