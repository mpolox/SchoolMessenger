using Microsoft.EntityFrameworkCore;
using SchoolMessengerAPI.Data;
using SchoolMessengerAPI.Data.Interfaces;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SchoolContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolMessengerDBConnection")));
builder.Services.AddScoped<IParentRepo, ParentRepo>();
builder.Services.AddScoped<IStudentRepo, StudentRepo>();
builder.Services.AddScoped<ISubjectRepo, SubjectRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        //schemas
        //options.DefaultModelsExpandDepth(-1);

        //collapsed
        options.DocExpansion(DocExpansion.None);    
    });    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();