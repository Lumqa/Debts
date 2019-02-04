using System.Collections.Generic;
namespace WebApplication.Models.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<Task> Tasks { get; }
    }
}
