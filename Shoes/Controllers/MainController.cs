using Microsoft.AspNetCore.Mvc;

namespace Shoes.Controllers;

public class MainController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}