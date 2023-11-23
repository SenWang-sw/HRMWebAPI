using JWTAuthManager;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using User.AppCore.Contract.Repo;
using User.AppCore.Contract.Services;
using User.AppCore.Models;
using User.Infras.Data;
using User.Infras.Repo;
using User.Infras.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionStr = Environment.GetEnvironmentVariable("UserDb");
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UserContextDb>(option =>
{
    if (connectionStr != null && connectionStr.Length > 1)
    {
        option.UseSqlServer(connectionStr);
    }
    else
    {
        option.UseSqlServer(builder.Configuration.GetConnectionString("UserDb"));
    }
    option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddIdentity<ApplicationUser,IdentityRole>()
    .AddEntityFrameworkStores<UserContextDb>()
    .AddDefaultTokenProviders();
builder.Services.AddSingleton<JwtTokenHandler>();
builder.Services.AddScoped<IAppUserRepo,AppUserRepo>();
builder.Services.AddScoped<IAppUserService,AppUserService>();
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
