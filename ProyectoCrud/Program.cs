using Microsoft.EntityFrameworkCore;
using ProyectoCrud.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar el builder aqui para la inyecci�n de dependencias
builder.Services.AddDbContext<ApplicationDbContext>(opciones => 
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql"))
);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
