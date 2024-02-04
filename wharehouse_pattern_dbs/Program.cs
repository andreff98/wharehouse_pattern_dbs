using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Text;
using wharehouse_pattern_dbs.Data.PostgreSQL;
using wharehouse_pattern_dbs.Data.SQLServer;
using wharehouse_pattern_dbs.Repositories;
using wharehouse_pattern_dbs.Repositories.PostgreSQL;
using wharehouse_pattern_dbs.Repositories.SQLServer;
using wharehouse_pattern_dbs.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Liga��o base de dadis
var connectionStringSQL = builder.Configuration.GetConnectionString("SQLServer");
builder.Services.AddDbContext<SqlContextDb>(options =>
    options.UseSqlServer(connectionStringSQL));

var connectionStringPostgre = builder.Configuration.GetConnectionString("PostgreSQL");
builder.Services.AddDbContext<PostgreSqlContextDb>(options =>
    options.UseNpgsql(connectionStringPostgre));

// Registar repositorios
//builder.Services.AddTransient<IEmployeeRepository, PostgreSqlRepository>();
builder.Services.AddTransient<IEmployeeRepository, SqlServerRepository>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Your API Name", Version = "v1" });
});


// Registar servi�os
builder.Services.AddTransient<IEmployeeService, EmployeeService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API Name v1");
        c.RoutePrefix = "swagger";
    });
}

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