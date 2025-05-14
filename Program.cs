using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using machine_test.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<machine_testContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("machine_testContext") ?? throw new InvalidOperationException("Connection string 'machine_testContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
//app.UsePathBase("/student");

app.Run();
