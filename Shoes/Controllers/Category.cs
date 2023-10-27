using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Shoes.Controllers;

public class Category : Controller
{
    private CategoryManager cm = new CategoryManager(new EfCategoryRepository());
    // GET
    public IActionResult Index()
    {
        var values = cm.Getlist();
        return View(values);
    }
}