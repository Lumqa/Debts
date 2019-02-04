using System.Collections.Generic;
namespace WebApplication.Models.Interfaces
{
    public interface IMemberRepository
    {
        IEnumerable<Member> Members { get; }
    }
}
