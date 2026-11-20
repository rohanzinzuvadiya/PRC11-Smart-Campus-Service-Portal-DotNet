using Microsoft.EntityFrameworkCore;
using SmartCampusPortal.Data;

var builder = WebApplication.CreateBuilder(args);

// MVC (controllers + views) and the REST API controllers live in the same project
builder.Services.AddControllersWithViews();

// Database: SQLite through Entity Framework Core
builder.Services.AddDbContext<CampusContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CampusDb")));

var app = builder.Build();

// Create the database file and add starter rows on first run
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<CampusContext>();
    SeedData.Initialize(context);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllers();      // attribute routed API controller (/api/requests)

app.Run();
