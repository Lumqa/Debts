using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Deposit { get; set; }
        public double Debt { get; set; }

        [ForeignKey("Task")]
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }
    }
}
