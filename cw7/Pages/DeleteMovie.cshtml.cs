using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw7.Pages;
{
    public class DeleteMovieModel : PageModel
    {
        public void OnGet(int? id)
        {
            if (id == null)
            {
                ViewData["Message"] = "Brak danych";
            }
            else
            {
                ViewData["Message"] = "Usuwanie filmu o id " + id;
            }
        }
    }
}