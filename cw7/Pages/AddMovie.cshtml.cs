using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using cw7.Models;

namespace cw7.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public Movie? MyMovie { get; set; }
        public void OnGet()
        {
        }
        public void OnPost(){
            
        }
    }
}
