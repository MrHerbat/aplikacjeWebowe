using cw7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw7.Pages
{
    public class DeleteMovieModel : PageModel
    {
        private MoviesRepo _repo = new MoviesRepo();
        public IActionResult OnGet(int? id)
        {
            if (id != null)
            {
                Movie? movie = _repo.GetById(id);
                if (movie != null)
                    _repo.DeleteMovie(movie);
            }

            return RedirectToPage("Index");
        }
    }
}