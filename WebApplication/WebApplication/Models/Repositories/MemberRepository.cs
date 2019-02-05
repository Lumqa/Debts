using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Models.Interfaces;

namespace WebApplication.Models.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public MemberRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Member> Members => _applicationDbContext.Members.Include(t => t.Task).ToList();

    }
}
