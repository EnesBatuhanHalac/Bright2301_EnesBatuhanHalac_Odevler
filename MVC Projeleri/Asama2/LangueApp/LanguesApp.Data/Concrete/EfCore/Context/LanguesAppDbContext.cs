using LanguesApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Context
{
    public class LanguesAppDbContext : DbContext
    {
        public LanguesAppDbContext()
        {
            
        }

        public LanguesAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Langue> Langues { get; set; }
  
        public DbSet<LangueTeacher> LangueTeachers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=LanguesApp.Db");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//burayi arastir
        }
    }
}
