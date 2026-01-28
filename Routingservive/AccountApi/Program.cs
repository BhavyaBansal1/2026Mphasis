using AccountApi.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddDbContext<AccountDbContext>(t=>t.UseSqlServer(builder.Configuration.GetConnectionString("Mycon")));
builder.Services.AddSwaggerGen();
builder.Services.AddCors(option=>{
    option.AddPolicy("AllowAngular",policy=>policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
    });
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.UseCors("AllowAngular");
app.Run();
