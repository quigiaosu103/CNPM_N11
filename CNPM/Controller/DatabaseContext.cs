using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNPM.Model;
using Microsoft.EntityFrameworkCore;
namespace CNPM.Controller
{
    internal class MyDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbConnection = "server=127.0.0.1;uid=root;pwd=;database=foodordering";
            optionsBuilder.UseMySql(dbConnection, ServerVersion.AutoDetect(dbConnection));
        }
        public DbSet<Account> Account { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>();
            modelBuilder.Entity<Customer>();

            base.OnModelCreating(modelBuilder);
        }



    }



}
