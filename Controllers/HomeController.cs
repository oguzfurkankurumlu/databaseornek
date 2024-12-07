using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using databaseornek.Models;

namespace databaseornek.Controllers;

public class HomeController : Controller
{
    private readonly UserDbContext _context;

    public HomeController(UserDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }


    [HttpPost]
    public IActionResult AddUser(User user)
    {

        _context.Users.Add(user);
        _context.SaveChanges();
        return RedirectToAction("Index");

    }


    public IActionResult Privacy()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
