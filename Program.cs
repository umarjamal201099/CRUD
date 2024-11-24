using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TaskManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register DbContext
builder.Services.AddDbContext<TaskManagerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TaskManagerContext")));  
builder.Services.AddRazorPages();  // Add Razor Pages

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();  // Enforce HTTP Strict Transport Security
}

app.UseHttpsRedirection();  // Redirect HTTP requests to HTTPS
app.UseStaticFiles();  // Enable static file serving

app.UseRouting();  // Enable routing

app.UseAuthorization();  // Enable authorization middleware

app.MapRazorPages();  // Map Razor Pages routes

app.Run();  // Run the app
