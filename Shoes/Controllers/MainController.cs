using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Shoes.Controllers;

public class MainController : Controller
{
    MainManager MainManager = new MainManager(new EfMainRepository());
    
    // GET
    public IActionResult Index()
    {
        var values = MainManager.Getlist();
        return View(values);
    }
}