using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        private readonly IMemberRepository _memberRepository;
        private readonly ITaskRepository _taskRepository;

        public MembersController(IMemberRepository eventRepository, ITaskRepository taskRepository)
        {
            _memberRepository = eventRepository;
            _taskRepository = taskRepository;
        }
        public IActionResult List(int id)
        {
            MemberListViewModel vm = new MemberListViewModel
            {
                Members = _memberRepository.Members.Where(s => s.TaskId == id)
            };

            Task task = _taskRepository.Tasks.First(s => s.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value && s.Id == id);

            return View(task);
        }
    }
}
