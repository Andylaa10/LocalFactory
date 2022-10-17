using System.Text.Json.Serialization;
using Application.DTOs;
using AutoMapper;
using Domain;
using FluentValidation;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Mapper
builder.Services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

var config = new MapperConfiguration(config =>
{
    config.CreateMap<PostCustomerDTO, Customer>();
    config.CreateMap<PutCustomerDTO, Customer>();
    config.CreateMap<PostBoxDTO, Box>();
    config.CreateMap<PutBoxDTO, Box>();
    config.CreateMap<PostOrderDTO, Order>();
}).CreateMapper();
builder.Services.AddSingleton(config);

builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//DependencyInjection
Application.DependencyResolver.DependencyResolverService.RegisterInfrastructureLayer(builder.Services);
Infrastructure.DependencyResolver.DependencyResolverService.RegisterInfrastructureLayer(builder.Services);

builder.Services.AddDbContext<RepositoryDbContext>(options => options.UseSqlite(
    "Data source=db.db"
));
builder.Services.AddScoped<BoxRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options =>
{
    options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//Connection to db. But blocked by rider  
/**
builder.Services.AddDbContext<RepositoryDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
*/