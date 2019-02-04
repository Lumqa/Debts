using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models.Mocks
{
    public class MockEventRepository : IMemberRepository
    {
        private readonly ITaskRepository _taskRepository = new MockTaskRepository();
        public IEnumerable<Member> Members
        {
            get
            {
                return new List<Member>
                {
                    new Member
                    {
                        Id = 0, Name = "Игорь", Deposit = 250, Debt = 100, Task = _taskRepository.Tasks.First()
                    },
                    new Member
                    {
                        Id = 1, Name = "Дима", Deposit = 150, Debt = 100, Task = _taskRepository.Tasks.First()
                    },
                    new Member
                    {
                        Id = 2, Name = "Саша", Deposit = 0, Debt = 100, Task = _taskRepository.Tasks.First()
                    },
                    new Member
                    {
                        Id = 3, Name = "Вова", Deposit = 0, Debt = 100, Task = _taskRepository.Tasks.First()
                    }
                };
            }

         set => throw new NotImplementedException(); }
    }
           
}
