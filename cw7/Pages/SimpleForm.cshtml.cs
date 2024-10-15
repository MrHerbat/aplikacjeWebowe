using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw7.Pages
{
    public class SimpleForm : PageModel
    {
        public void OnGet()
        {
            var request = Request;
            ViewData["Query"] = request.Query;
            ViewData["Query"] = request.Query["name"];
            ViewData["Query"] = request.Query["number"];
        }
    }
}
