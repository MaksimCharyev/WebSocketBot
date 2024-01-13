
using System.ComponentModel.DataAnnotations;

namespace WebSocketBot.DatabaseContext.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
    }
    public class File
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
    public class Worker
    {
        [Key]
        public int Id { get; set; }
        public int Karma { get; set; }
        public User? User { get; set; }
    }
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public User? Customer { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime Deadline { get; set; }
        public decimal Price { get; set; }
        public decimal FixedPrice { get; set; }   
        public File? File { get; set; }
    }
    public class Worker_has_order
    {
        [Key]
        public int WOID { get; set; }
        public Worker? Worker { get; set; }
        public Order? Order { get; set;}
        public DateTime PickTime { get; set; } 
    }
    public class Worker_done_order
    {
        [Key]
        public int WOID { get; set; }
        public Worker? Worker { get; set; }
        public Order? Order { get; set; }
        public DateTime DoneTime { get; set; }
    }
}
