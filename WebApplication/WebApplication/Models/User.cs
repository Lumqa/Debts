using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApplication.Models
{
    public class User : IdentityUser
    {
        

        public ICollection<Task> Tasks { get; set; }
        public User()
        {
            Tasks = new List<Task>();
        }
    }
}
