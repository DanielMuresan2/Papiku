using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPapi.Models
{
    public class MigratingMenuDBContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        public DbSet<CurrentMenu> CurrentMenus { get; set; }
        public DbSet<DailyMenu> DailyMenus { get; set; }

        public DbSet<WeeklyMenu> WeeklyMenus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrentMenu>().HasMany(t => t.Foods).WithMany(t => t.CurrentMenus);
            modelBuilder.Entity<DailyMenu>().HasMany(t => t.CurrentMenus).WithMany(t => t.DailyMenus);
            modelBuilder.Entity<WeeklyMenu>().HasMany(t => t.DailyMenus); //not many to many because each day belongs to only 1 week!
            base.OnModelCreating(modelBuilder);
        }
    }
}