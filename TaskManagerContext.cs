using Microsoft.EntityFrameworkCore;
using CRUD.Models;  // Make sure to use the correct namespace where TaskItem is defined

namespace TaskManager
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options)
            : base(options)
        { }

        public virtual DbSet<TaskItem> Tasks { get; set; }  
    }
}
