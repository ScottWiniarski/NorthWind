using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
    // private NorthwindContext _NorthwindContext;
    // public HomeController(NorthwindContext db) => _NorthwindContext = db;
    // public IActionResult Index() => View();
    public IActionResult Index() => View();
}
