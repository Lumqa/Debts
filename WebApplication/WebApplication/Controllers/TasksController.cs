using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.Models.Interfaces;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskRepository _taskRepository;

        public TasksController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public IActionResult List()
        {
            TaskListViewModel vm = new TaskListViewModel
            {
                Tasks = _taskRepository.Tasks.Where(s => s.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value)
            };

            return View(vm);
        }
    }
}
