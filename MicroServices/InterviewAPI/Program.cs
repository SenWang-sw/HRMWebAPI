using Interview.AppCore.Contract.Repos;
using Interview.AppCore.Contract.Services;
using Interview.Infras.Data;
using Interview.Infras.Repos;
using Interview.Infras.Services;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
var connectionString = Environment.GetEnvironmentVariable("InterviewDb");
//Console.WriteLine($"InterviewDb value: {connectionStr}");
//exception handling
builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<InterviewDbContext>(option =>
{
    
    if (connectionString != null && connectionString.Length > 1)
    {
        option.UseSqlServer(connectionString);
    }
    else
    {
        option.UseSqlServer(builder.Configuration.GetConnectionString("InterviewDb"));
    }
    
    //option.UseSqlServer(builder.Configuration.GetConnectionString("InterviewDb"));
    option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddScoped<IInterviewTypeRepositoryAsync,InterviewTypeRepositoryAsync>();
builder.Services.AddScoped<IInterviewerRepositoryAsync,InterviewerRepositoryAsync>();
builder.Services.AddScoped<IInterviewFeedbackRepositoryAsync, InterviewFeedbackRepository>();
builder.Services.AddScoped<IInterviewRepositoryAsync,InterviewRepositoryAsync>();
builder.Services.AddScoped<IRecruiterRepositoryAsync,RecruiterRepositoryAsync>();

builder.Services.AddScoped<IInterviewTypeServiceAsync, InterviewTypeServiceAsync>();
builder.Services.AddScoped<IInterviewerServiceAsync,InterviewerServiceAsync>();
builder.Services.AddScoped<IRecruiterServiceAsync,RecruiterServiceAsync>();
builder.Services.AddScoped<IInterviewServiceAsync,InterviewServiceAsync>();
builder.Services.AddScoped<IInterviewFeedbackServiceAsync,InterviewFeedbackServiceAsync>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
    //global
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
