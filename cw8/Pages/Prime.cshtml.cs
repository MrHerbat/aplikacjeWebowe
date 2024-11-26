using System.Text.Encodings.Web;
using cw8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw8.Pages
{
    public class PrimeModel : PageModel
    {
        [BindProperty]
        public int Count { get; set; }
        public List<int> Numbers { get; set; }
        
        public void OnPost()
        {
            if (Count == null)
            {
                ViewData["Message"] = "Brak danych";
            }
            else
            {
                Numbers = Models.PrimeNumbers.GeneratePrimeNumbers(Count);
            }
        }
    }
}