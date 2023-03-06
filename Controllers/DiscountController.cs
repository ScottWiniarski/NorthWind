using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Northwind.Models;

public class DiscountController : Controller
{
   // this controller depends on the BloggingRepository
  private NorthwindContext _dataContext;
  public DiscountController(NorthwindContext db) => _dataContext = db;

  // public IActionResult Index() => View();
  public IActionResult Index() => View(_dataContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now ));

  // pass to the view a list of matching products based on the category id
  }