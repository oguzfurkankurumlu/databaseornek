
using Microsoft.AspNetCore.Mvc;

public class UserDbController : Controller
{
    public UserDbContext _context;

    public UserDbController(UserDbContext context)
    {
        _context = context;
    }

    public IActionResult GetUsersWithDatabase()
    {
        List<User> Users = _context.Users.ToList();

        return View();

    }
}