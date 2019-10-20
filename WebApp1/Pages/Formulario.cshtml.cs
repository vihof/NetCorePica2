using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApp1.Pages
{
    public class FormularioPage : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Ingrese el nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ingrese el Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Ingrese el numero de celular")]
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