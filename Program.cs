var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
//here is where you can map controllers.
app.MapControllers();


//here application starts webapplication
app.Run();
