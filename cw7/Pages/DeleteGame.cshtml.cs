using cw7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw7.Pages
{
    public class DeleteGameModel : PageModel
    {
        private GamesRepo _repo = new GamesRepo();
        public IActionResult OnGet(int? id)
        {
            if (id != null)
            {
                Game? movie = _repo.GetById(id);
                if (movie != null)
                    _repo.DeleteGame(movie);
            }

            return RedirectToPage("Games");
        }
    }
}

