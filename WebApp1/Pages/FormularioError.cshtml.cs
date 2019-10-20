using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApp1.Pages
{
    public class FormularioErrorPage : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Pongale el nombre")]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Celular { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost(string name, string email, string celular)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Page();
        }
    }
}