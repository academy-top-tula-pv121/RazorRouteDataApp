using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorRouteDataApp.Pages
{
    public class EmplsModel : PageModel
    {
        ITimeService timeService;

        List<Employee> employees = new()
        {
            new(){ Name = "Bob", Age = 32 },
            new(){ Name = "Joe", Age = 19 },
            new(){ Name = "Sam", Age = 24 },
            new(){ Name = "Ben", Age = 38 },
            new(){ Name = "Tim", Age = 21 },
        };

        public List<Employee> EmployeesList { get; set; } = new();

        public EmplsModel(ITimeService timeService)
        {
            this.timeService = timeService;
        }

        public void OnGet()
        {
            EmployeesList = employees;
        }
        public void OnGetByName()
        {
            EmployeesList = employees.OrderBy(e => e.Name).ToList();
        }

        public void OnGetByAge(int age)
        {
            EmployeesList = employees.Where(e => e.Age >= age).ToList();
        }

        public IActionResult OnGetHello(string? name)
        {
            return Content($"Hello {name}, time now: {timeService.GetTime}");
        }
    }
}
