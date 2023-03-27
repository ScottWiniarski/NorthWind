using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Northwind.Models;

public class CustomerController : Controller {
    private NorthwindContext _dataContext;

    public CustomerController(NorthwindContext db) => _dataContext = db;
    public IActionResult Index() => View(_dataContext.Customers.OrderBy(d => d.CompanyName));

    public IActionResult Register() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(Customer model)
  {
    if (ModelState.IsValid)
    {
      if (_dataContext.Customers.Any(b => b.CompanyName == model.CompanyName))
      {
        ModelState.AddModelError("", "Name must be unique");
      }
      else
      {
        _dataContext.AddCustomer(model);
        return RedirectToAction("Index");
      }
    }
    return View();
  }
}