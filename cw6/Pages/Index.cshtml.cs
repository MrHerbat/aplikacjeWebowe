using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cw6.Models;

namespace cw6.Pages
{
    public class IndexModel : PageModel
    {
        public List<Game> Games { get; set; }

        public void OnGet()
        {
            Games = GetGames();
        }
        
        public static List<Game> GetGames()
        {
            return new List<Game>
            {
                new Game { GameName = "Helldivers 2", GameCost = 189.99f, GameYear = 2024 },
                new Game { GameName = "Minecraft", GameCost = 129.99f, GameYear = 2009 },
                new Game { GameName = "Stardew Valley", GameCost = 53.99f, GameYear = 2016 }
            };
        }
    }
}