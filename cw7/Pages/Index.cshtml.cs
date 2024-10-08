using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cw7.Models;


namespace cw7.Pages
{
    public class IndexModel : PageModel
    {
        public List<Movie> Movies { get; set; }
        private MoviesRepo _repo;
        public IndexModel()
        {
            _repo = new MoviesRepo("movies.json");
        }
        public void OnGet()
        {
            
            Movies = _repo.Movies ?? new List<Movie>();
        }
    }
}