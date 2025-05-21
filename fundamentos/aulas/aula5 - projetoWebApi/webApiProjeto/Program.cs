

using webApiProjeto.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");
if (app.Environment.IsDevelopment())
{
    
    app.UseSwagger(); //serve o arquivo JSON da especificação swagger
    app.UseSwaggerUI(); //serve a interface grafica
}
app.MapGet("/swagger/client", () =>
{


});


app.UseHttpsRedirection();
app.Run();

