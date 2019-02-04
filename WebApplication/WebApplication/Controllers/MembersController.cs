using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.Models.Interfaces;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    [Authorize]
    public class MembersController : Controller
    {
        private readonly IMemberRepository _eventRepository;
        private readonly ITaskRepository _taskRepository;
        private readonly UserManager<User> _userManager;

        public MembersController(IMemberRepository eventRepository, UserManager<User> userManager, ITaskRepository taskRepository)
        {
            _eventRepository = eventRepository;
            _userManager = userManager;
            _taskRepository = taskRepository;
        }
        public IActionResult List(int id)
        {
            MemberListViewModel vm = new MemberListViewModel
            {
                Members = _eventRepository.Members.Where(s=>s.TaskId==id)
            };
            ViewBag.User = _taskRepository.Tasks.First().Name;

            ViewBag.User2 = _taskRepository.Tasks.First().Members.Count;

            return View(vm);
        }
    }
}
