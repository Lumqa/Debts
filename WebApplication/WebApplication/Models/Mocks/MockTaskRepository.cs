using System.Collections.Generic;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models.Mocks
{
    public class MockTaskRepository : ITaskRepository
    {
        public IEnumerable<Task> Tasks
        {
            get
            {
                return new List<Task>
                {
                    new Task { Id = 1, Name = "Билеты", Sum = 400 },
                    new Task { Id = 2, Name = "Ресторан", Sum = 200 }
                };
            }
        }
    }
}
