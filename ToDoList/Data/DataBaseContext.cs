using Microsoft.EntityFrameworkCore;

namespace ToDoList.Data
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
        }

        public DbSet<ToDoListContext> toDoListContexts { get; set; }
    }
}
