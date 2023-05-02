using JWTAuthManager;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Recruiting.AppCore.Contract.Repos;
using Recruiting.AppCore.Contract.Services;
using Recruiting.Infras.Data;
using Recruiting.Infras.Repos;
using Recruiting.Infras.Services;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
var connectionStr = Environment.GetEnvironmentVariable("RecruitingDb");
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//auth
builder.Services.AddCustomJwtTokenService();
builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
builder.Services.AddDbContext<RecruitingDbContext>(option =>
{
    if (connectionStr!=null&&connectionStr.Length>1)
    {
        option.UseSqlServer(connectionStr);
    }
    else
    {
        option.UseSqlServer(builder.Configuration.GetConnectionString("RecruitingDb"));
    }
    option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
//repo injections
builder.Services.AddScoped<ICandidateRepositoryAsync,CandidateRepositoryAsync>();
builder.Services.AddScoped<IJobRequirementRepositoryAsync,JobrequirementRepositoryAsync>();
builder.Services.AddScoped<ISubmissionRepositoryAsync,SubmissionRepositoryAsync>();
builder.Services.AddScoped<ISubmissionStatusRepositoryAsync,SubmissionStatusRepositoryAsync>();
//service injections
builder.Services.AddScoped<ICandidateServiceAsync,CandidateServiceAsync>();
builder.Services.AddScoped<IJobrequirementServiceAsync,JobRequirementServiceAsync>();
builder.Services.AddScoped<ISubmissionServiceAsync,SubmissionServiceAsync>();
builder.Services.AddScoped<ISubmissionStatusServiceAsync,SubmissionStatusServiceAsync>();

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
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseCors();
app.MapControllers();

app.Run();
