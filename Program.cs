using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Add health checks service to the container
builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

// Configure health checks endpoints.
// Endpoint to check the liveness of the application.
app.UseHealthChecks("/health/live", new HealthCheckOptions()
{
    Predicate = check => check.Name == "Liveness"
});
// Endpoint to check if the application is ready to handle requests.
app.UseHealthChecks("/health/ready", new HealthCheckOptions()
{
    Predicate = check => check.Name == "Readiness",

});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
