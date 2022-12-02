using Northwind;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => NorthwindDb.GetData());



app.Run();
