using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using TestApp.Data;
using TestApp.Data.Dto;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllersWithViews()
    .AddJsonOptions(c => c.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

services.AddAutoMapper(typeof(CompanyProfile).Assembly);
services.AddDbContext<CompanyContext>(options =>
    options.UseSqlServer(@"Data Source=DESKTOP-24PO16E;Database=CompanyDB;Integrated Security=True;TrustServerCertificate=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
