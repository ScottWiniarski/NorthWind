using Microsoft.EntityFrameworkCore;
using Northwind.Models;

// Connection info stored in appsettings.json
IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
// Register the DataContext service
//builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration["Data:Blog:ConnectionString"]));
builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(configuration["Data:Northwind:ConnectionString"]));
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    // pattern: "{controller=Product}/{action=Category}/{id?}");
app.Run();

