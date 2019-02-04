using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
    public class MemberListViewModel
    {
        public IEnumerable<Member> Members { get; set; }
    }
}
