using eShopApi.Data;
using eShopApi.Interfaces;
using eShopApi.Repository;
using eShopApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<eShopDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnString")));

builder.Services.AddScoped<IUserDetail, UserDetailRepo>();
builder.Services.AddScoped<UserDetailService, UserDetailService>();
builder.Services.AddScoped<IProduct, ProductRepo>();
builder.Services.AddScoped<ProductService, ProductService>();
builder.Services.AddScoped<IFeedback, FeedbackRepo>();
builder.Services.AddScoped<FeedbackService, FeedbackService>();
builder.Services.AddScoped<ICart, CartRepo>();
builder.Services.AddScoped<CartService, CartService>();
builder.Services.AddScoped<IOrder, OrderRepo>();
builder.Services.AddScoped<OrderService, OrderService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
