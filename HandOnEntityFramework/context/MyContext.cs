using System;
using System.Collections.Generic;
using System.Text;
using HandOnEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
namespace HandOnEntityFramework.context
{
    class MyContext:DbContext
    {
        public DbSet<student> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-I3GJCG7\SQLEXPRESS;User ID=sa;Password=pass@word1");
            
        }
    }
}
