using System.Collections.Generic;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public TaskRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Task> Tasks => _applicationDbContext.Tasks;
    }
}
