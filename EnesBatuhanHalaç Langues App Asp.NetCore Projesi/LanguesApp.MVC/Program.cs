using LanguesApp.Business.Abstract;
using LanguesApp.Business.Concrete;
using LanguesApp.Data.Abstract;
using LanguesApp.Data.Concrete.EfCore.Context;
using LanguesApp.Data.Concrete.EfCore.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


builder.Services.AddScoped<ITeacherRepository, EFCoreTeacherRepository>();
builder.Services.AddScoped<ITeacherService, TeacherManager>();
builder.Services.AddScoped<ILangueRepository, EFCoreLangueRepository>();
builder.Services.AddScoped<ILangueService, LangueManager>();


builder.Services.AddDbContext<LanguesAppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});


var app = builder.Build();







if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapRazorPages();
app.Run();
