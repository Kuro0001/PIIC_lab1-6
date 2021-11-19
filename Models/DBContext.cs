using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Kind> Kinds { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourOperator> TourOperators { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        { }
    }
}
