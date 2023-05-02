using Emp.AppCore.Contract.Repo;
using Emp.AppCore.Contract.Service;
using Emp.Infras.Data;
using Emp.Infras.Repo;
using Emp.Infras.Service;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
var connectionStr = Environment.GetEnvironmentVariable("EmpDb");
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/*
builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
*/
builder.Services.AddDbContext<EmpDbContext>(option =>
{
    if (connectionStr != null && connectionStr.Length > 1)
    {
        option.UseSqlServer(connectionStr);
    }
    else
    {
        option.UseSqlServer(builder.Configuration.GetConnectionString("EmpDb"));
    }
    option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddScoped<IEmpRepo, EmpRepo>();
builder.Services.AddScoped<IEmpCateRepo, EmpCateRepo>();
builder.Services.AddScoped<IEmpRoleRepo, EmpRoleRepo>();
builder.Services.AddScoped<IEmpStatusRepo, EmpStatusRepo>();

builder.Services.AddScoped<IEmpService, EmpService>();
builder.Services.AddScoped<IEmpRoleService, EmpRoleService>();
builder.Services.AddScoped<IEmpCateService, EmpCateService>();
builder.Services.AddScoped<IEmpStatusService, EmpStatusService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseExceptionHandler(option =>
    {
        option.Run(async context =>
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var ex = context.Features.Get<IExceptionHandlerFeature>();
            if (ex != null)
            {
                await context.Response.WriteAsync(ex.Error.ToString());
            }
        });
    });

}

app.UseAuthorization();

app.MapControllers();

app.Run();
