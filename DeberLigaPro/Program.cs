using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Jugadorbdcontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Jugadorbdcontext") ?? throw new InvalidOperationException("Connection string 'Jugadorbdcontext' not found.")));
builder.Services.AddDbContext<Estadiodbcontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Estadiodbcontext") ?? throw new InvalidOperationException("Connection string 'Estadiodbcontext' not found.")));
builder.Services.AddDbContext<Equipodbcontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Equipodbcontext") ?? throw new InvalidOperationException("Connection string 'Equipodbcontext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
