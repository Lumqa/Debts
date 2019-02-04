using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Sum { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }
    
        public List<Member> Members { get; set; }

        public List<Debt> Debts { get; set; }

        public Task()
        {
            Members = new List<Member>();
            Debts = new List<Debt>();
        }

    }
}
