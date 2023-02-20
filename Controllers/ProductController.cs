using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Northwind.Models;

public class ProductController : Controller
{
   // this controller depends on the BloggingRepository
  private NorthwindContext _dataContext;
  public ProductController(NorthwindContext db) => _dataContext = db;

    // public IActionResult Index() => View();
    public IActionResult Category() => View(_dataContext.Categories.OrderBy(c => c.CategoryName));
}
