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

  // pass to the view a list of matching products based on the category id
  public IActionResult Index(int id) => View(_dataContext.Products.Where(p => p.CategoryId == id && p.Discontinued == false).OrderBy(p => p.ProductName));
}
