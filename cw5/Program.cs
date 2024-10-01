using cw5.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
var p = new Person { 
    FirstName = "Jan", 
    LastName = "Kowalski", 
    Age = 20 
};

app.MapRazorPages();
// app.MapGet("/", () => "Hello World!");
// app.MapGet("/games", () => GamesRepo.GetGames());
// app.MapGet("/strona1", () => "Strona 1");
// app.MapGet("/strona2", () => GetPersons());

app.Run();


static List<Person> GetPersons()
{
    return new List<Person>
    {
        new Person{FirstName="Tomasz",LastName="Rączka",Age=15},
        new Person{FirstName="Jakub",LastName="Mueller",Age=16},
        new Person{FirstName="Karolinka",LastName="Mueller",Age=16},
        new Person{FirstName="Chris",LastName="Armatys",Age=17},
        new Person{FirstName="Anastazja",LastName="Matys",Age=17},
        new Person{FirstName="Mateusz",LastName="Tokaszewicz",Age=17}
    };
}