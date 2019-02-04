using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication.Models
{
    public class DbInitializer
    {
        private static Dictionary<string, Task> _tasks;
        public static Dictionary<string, Task> Tasks
        {
            get
            {
                if(_tasks == null)
                {
                    //var user = new User {Email = "user@user.com", PasswordHash = "AQAAAAEAACcQAAAAEO+IKHRPYG70PVf8svaFx8R31qxfWeJH1lItpTupv4ww8Mm/khfzHana98lYrCUZ1Q=="};
                    var genresList = new []
                    {
                        new Task { Name = "Билеты", Sum = 400},
                        new Task { Name = "Ресторан", Sum = 200}
                    };

                    _tasks = new Dictionary<string, Task>();

                    foreach (Task genre in genresList)
                    {
                        _tasks.Add(genre.Name, genre);
                    }
                }
                return _tasks;
            }
        }
        public static void Seed(IApplicationBuilder app)
        {
            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using (var scope = scopeFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                context.Database.Migrate();
                if (!context.Tasks.Any())
                {
                    context.Tasks.AddRange(Tasks.Select(t => t.Value));
                }
                if (!context.Members.Any())
                {
                    context.AddRange
                    (
                        new Member
                        {
                            Name = "Игорь",
                            Deposit = 250,
                            Debt = 100,
                            Task = Tasks["Билеты"]
                        },
                        new Member
                        {
                            Name = "Дима",
                            Deposit = 150,
                            Debt = 100,
                            Task = Tasks["Билеты"]
                        },
                        new Member
                        {
                            Name = "Саша",
                            Deposit = 0,
                            Debt = 100,
                            Task = Tasks["Билеты"]
                        },
                        new Member
                        {
                            Name = "Вова",
                            Deposit = 0,
                            Debt = 100,
                            Task = Tasks["Билеты"]
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
