using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSocketBot.DatabaseContext.Models;
namespace WebSocketBot.DatabaseContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> users { get; set; } = null!;
        public DbSet<Worker> workers { get; set; } = null!;
        public DbSet<Order> orders { get; set; } = null!;
        public DbSet<DatabaseContext.Models.File> files { get; set; } = null!;
        public DbSet<Worker_done_order> worker_done_orders { get; set; } = null!;
        public DbSet<Worker_has_order> worker_has_orders { get; set; } = null!;
        public ApplicationContext() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=password;database=mydb", new MySqlServerVersion(new Version(8,0,30)));
        }
    }
}
