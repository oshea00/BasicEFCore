using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SqlOsx
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DemoContext())
            {
                context.ToDos.Add(new ToDo { Description = "Sample ToDo", IsDone = false });
                context.SaveChanges();
            }
        }
    }

    public class ToDo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ToDoId { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }

    public class DemoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("server=localhost,1433;database=Demo;user id=sa;password=reallyStrong1Pwd");
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
