using Microsoft.EntityFrameworkCore;

namespace СallСenter.Data.Tasks
{
    public class TaskContext : DbContext
    {
        public DbSet<TaskDto> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tasks.db");         
        }
    }
}