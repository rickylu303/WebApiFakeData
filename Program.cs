using Microsoft.EntityFrameworkCore;
using WebApiFakeData.Configurations;
using WebApiFakeData.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddBll();
builder.Services.AddDbContext<AllContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("FdConnectionString")));


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI(x => x.DocumentTitle = "FakeData WebApi With Layers");
//}

app.UseAuthorization();

app.MapControllers();

app.Run();
