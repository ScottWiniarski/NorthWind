using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
    // private NorthwindContext _NorthwindContext;
    // public HomeController(NorthwindContext db) => _NorthwindContext = db;
    // public IActionResult Index() => View();
    // this controller depends on the NorthwindRepository
     // this controller depends on the BloggingRepository
  private NorthwindContext _dataContext;
  public HomeController(NorthwindContext db) => _dataContext = db;
    //public ActionResult Index() => View(_dataContext.Discounts);
    public ActionResult Index() => View(_dataContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now).Take(3));
}
