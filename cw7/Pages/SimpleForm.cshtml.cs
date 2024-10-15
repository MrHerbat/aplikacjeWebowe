using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw7.Pages
{
    public class SimpleForm : PageModel
    {
        public void OnPost()
        {
            var request = Request;
            
            ViewData["firstname"] = request.Form["firstname"];
            ViewData["age"] = request.Form["age"];
            
        }
        public void OnGet()
        {
            var request = Request;
            ViewData["Query"] = request.Query;
            ViewData["Query"] = request.Query["firstname"];
            ViewData["Query"] = request.Query["age"];
            
        }
    }
}
