using Microsoft.EntityFrameworkCore;
using TaskQueue.Domain;

namespace TaskQueue.Infrastructure.Persistence;

public class TaskQueueDbContext: DbContext
{
    public TaskQueueDbContext(DbContextOptions<TaskQueueDbContext> options)
        : base(options)
    {
    }

    public DbSet<Job> Jobs => Set<Job>(); 
}