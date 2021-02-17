using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages_TestProject_HelemaalOpnieuwMaken.Models;

namespace RazorPages_TestProject_HelemaalOpnieuwMaken.Data
{
    public class RepairOrderDbContextCollection : DbContext
    {
        public RepairOrderDbContextCollection (DbContextOptions<RepairOrderDbContextCollection> options)
            : base(options)
        {
        }

        public DbSet<RepairOrder> RepairOrders { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RepairOrderDetail> RepairOrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RepairOrder>().ToTable("RepairOrder");
            modelBuilder.Entity<Part>().ToTable("Part");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<RepairOrderDetail>().ToTable("RepairOrderDetail");
        }
    }
}
