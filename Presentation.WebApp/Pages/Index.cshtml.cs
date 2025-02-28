using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Presentation.WebApp.Models;

namespace Presentation.WebApp.Pages;

public class IndexModel : PageModel
{
    public List<User> Users { get; set; } = [];
    public void OnGet()
    {
        Users = 
        [
            new User { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@domain.com" },
            new User { Id = 2, FirstName = "Jane", LastName = "Doe", Email = "jane@domain.com" },
            new User { Id = 3, FirstName = "Alice", LastName = "Smith", Email = "alice@domain.com" },
            new User { Id = 4, FirstName = "Bob", LastName = "Smith", Email = "bob@domain.com" }
            ];
    }
}
