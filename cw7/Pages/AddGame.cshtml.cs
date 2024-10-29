using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cw7.Models;

namespace cw7.Pages
{
    public class AddGameModel : PageModel
    {
        [BindProperty]
        public Game? MyGame { get; set; }
        public List<string>? Genres { get; set; }
        public AddGameModel()
        {
            Genres = new List<string> {
                "RPG", "FPS", "TBS",
                "RTS","Horror","Adventure",
                "Action","Soulslike" };
        }
        public void OnGet()
        {
            ViewData["Genres"] = Genres;
            ViewData["Message"] = "Dopiero wywitlamy formularz";
        }
        public IActionResult OnPost()
        {
            if(MyGame == null)
            {
                ViewData["Message"] = "Brak danych";
                return Page();
            }
            ViewData["Genres"] = Genres;
            if (ModelState.IsValid)
            {
                // Add movie to database
                GamesRepo repo = new GamesRepo("games.json");
                repo.AddGame(MyGame);
                ViewData["Message"] = "Gra dodana";
                return RedirectToPage("Index");
            }
            else
            {
                ViewData["Message"] = "Niepoprawne dane";                
            }
            return Page();
        }
    }
}