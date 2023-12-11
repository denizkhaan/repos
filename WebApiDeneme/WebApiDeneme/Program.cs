using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApiDeneme.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<ApplicationDbContext>();
string connString = builder.Configuration.GetConnectionString("DefaultConn");

builder.Services.AddDbContext<ApplicationDbContext>(Options => Options.UseSqlServer(connString));
var app = builder.Build();

builder.Services.AddCors(Options =>
{
    Options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseCors("Open");
app.UseAuthorization();

app.MapControllers();

app.Run();
