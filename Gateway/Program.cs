using Ocelot.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Configuration.AddJsonFile("Ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddOcelot();
app.MapGet("/", () => "Hello World!");

app.Run();
