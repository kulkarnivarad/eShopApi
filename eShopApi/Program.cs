using eShopApi.Data;
using eShopApi.Interfaces;
using eShopApi.Repository;
using eShopApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<eShopDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnString")));

//CorsHeader
builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod())
);


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
builder.Services.AddScoped<IAddress, AddressRepo>();
builder.Services.AddScoped<AddressService, AddressService>();
builder.Services.AddScoped<IPayment, PaymentRepo>();
builder.Services.AddScoped<PaymentService, PaymentService>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidAudience = builder.Configuration["JWT:Audience"],
            ValidIssuer = builder.Configuration["JWT:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
        };
    });

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthentication();    

app.UseAuthorization();

app.MapControllers();

app.Run();
