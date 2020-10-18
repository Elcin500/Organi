using Microsoft.EntityFrameworkCore;
using Organi.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organi.WebUI.Models.DataContext
{
    public class OrganiDbContext : DbContext
    {

        public OrganiDbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppInfo> AppInfos { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>(e =>
            {
                e.Property(p => p.CreatedDate)
                .HasDefaultValueSql("dateadd(hour,4,getutcdate())");
                //.HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<Contact>(e =>
            {
                e.Property(p => p.CreatedDate)
                .HasDefaultValueSql("dateadd(hour,4,getutcdate())");
                //.HasDefaultValue(DateTime.Now);
            });
            modelBuilder.Entity<Post>(e =>
            {
                e.Property(p => p.CreatedDate)
                .HasDefaultValueSql("dateadd(hour,4,getutcdate())");
                //.HasDefaultValue(DateTime.Now);
            });

        }
    }
}
