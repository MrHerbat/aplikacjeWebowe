using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cw7.Models;

namespace cw7.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public Movie? Movie { get; set; }
        
        public void OnGet()
        {
        }
    }
}
