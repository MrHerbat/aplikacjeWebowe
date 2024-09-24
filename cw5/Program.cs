using cw5.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/", () => "Hello World!");
app.MapGet("/strona1", () => "Strona 1");
app.MapGet("/strona2", () => GetPeople());

app.Run();


List<Person> GetPeople()
{
    var list = new List<>();
    list.Add(new Person { FirstName = "Jan", LastName = "Kowalski", Age = 20 });
    list.Add(new Person { FirstName = "Damian", LastName = "Jabłko", Age = 14 });
    list.Add(new Person { FirstName = "Nikolai", LastName = "Romanov", Age = 156 });
    return list;
}