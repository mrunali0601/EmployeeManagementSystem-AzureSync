using EmployeeManagementSystem.Application;
using EmployeeManagementSystem.Domain.Entities;
using EmployeeManagementSystem.Persistence;
using EmployeeManagementSystem.Persistence.Context;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<EMSDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Employee Management API",
        Version = "v1"
    });
      c.SwaggerGeneratorOptions = new Swashbuckle.AspNetCore.SwaggerGen.SwaggerGeneratorOptions
    {
        SwaggerDocs = new Dictionary<string, Microsoft.OpenApi.Models.OpenApiInfo>
        {
            { "v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Employee Management API", Version = "v1" } }
        }
    };
});

builder.Services.AddApplicationServices();
// Register persistence services
builder.Services.AddInterfaceServices(builder.Configuration);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();
app.UseCors("AllowAll");
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee Management API v1");
});

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
