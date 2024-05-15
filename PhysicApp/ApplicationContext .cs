using Microsoft.EntityFrameworkCore;

namespace PhysicApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Topic> Topics { get; set; } // Коллекция тем из базы данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=topics.db"); // Настройка подключения к базе данных SQLite
        }
    }
}
