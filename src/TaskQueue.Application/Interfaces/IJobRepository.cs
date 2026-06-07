using TaskQueue.Domain;

using TaskQueue.Application.Interfaces;

public interface IJobRepository
{
    Task<Job> AddAsync(Job job);

    Task<Job> GetIdByAsync(Guid id);
}