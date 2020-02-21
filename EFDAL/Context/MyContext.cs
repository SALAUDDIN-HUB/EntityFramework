using EFDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDAL.Context
{
   public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-I3GJCG7\SQLEXPRESS;User ID=sa;Password=pass@word1");
        }
        public DbSet<Project4> Project4s { get; set; }
        public DbSet<Employee> Employees { get; set; } 
    }
}
