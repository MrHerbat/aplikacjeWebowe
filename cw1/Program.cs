using cw1.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/", () => "Hello World!");
app.MapGet("/date", () => DateTime.Now.ToShortDateString());
app.MapGet("/imie", () => {
    String FirstName = "Aloizy";
    String LastName = "Paluch";
    return "Witaj "+FirstName+" "+LastName;
});
app.MapGet("/persons",() => PersonRepo.GetPersons());
app.MapGet("/books", () => BookRepo.GetBooks());
app.Run();
