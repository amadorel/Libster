using LibsterFinalProj.Services;
using LibsterFinalProj.Models.Entities;
using Microsoft.EntityFrameworkCore.Sqlite; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI; 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IApplicationUserRepository, DbUserRepository>(); 

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(
      builder.Configuration.GetConnectionString("DefaultConnection"))
);

//Identity service 
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication(); 
app.UseAuthorization();

app.MapStaticAssets();

app.MapRazorPages(); 

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
