using cw7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw7.Pages
{
    public class EditMovieModel : PageModel
    {
        [BindProperty]
        public Movie? MyMovie { get; set; }

        private readonly MoviesRepo _repo = new MoviesRepo();
        public List<string> Genres { get; set; }
        public EditMovieModel()
        {
            Genres = new List<string> {
                "Action", "Crime", "Drama",
                "Fantasy","Sci-Fi","Comedy",
                "Horror" };
        }

        

        public void OnGet(int id)
        {

            ViewData["Genres"] = Genres;
            var movieToEdit = _repo.GetById(id);
            if (movieToEdit != null)
            {
                MyMovie = movieToEdit;
            }
        }
        public IActionResult OnPost(){
            if(ModelState.IsValid){
                var movie = MyMovie;
                //TODO zapisywanie do pliku
                _repo.UpdateMovie(movie);
                return RedirectToPage("Index");
            }
            return Page();
            
        }
    }
}
