var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Football}/{action=Index}/{id?}");
//app.MapGet("/", () => "Hello World!");

app.Run();