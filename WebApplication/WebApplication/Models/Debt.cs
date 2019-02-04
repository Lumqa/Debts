using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Debt
    {
        public int Id { get; set; }
        public string Member1 { get; set; }
        public string Member2 { get; set; }
        public double Money { get; set; }

        [ForeignKey("Task")]
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }
    }
}
