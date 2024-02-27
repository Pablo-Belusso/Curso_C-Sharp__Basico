using Microsoft.EntityFrameworkCore;
using WebCrudMVCSQL.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>
    // Conexão com o Banco de Dados (SQL Server)
    (options => options.UseSqlServer("Data Source=DESKTOP-EUHGO67\\pablo;Initial Catalog=CRUD_MVC_SQL_CANAL_DEV;Integrated Security=False;User ID=pablo;Password=123;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"));
     
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
