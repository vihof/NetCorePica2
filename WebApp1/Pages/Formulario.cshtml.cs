using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApp1.Pages
{
    public class FormularioPage : PageModel
    {
        [BindProperty]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Ingrese el nombre")]
        public string Name { get; set; }
        
        [BindProperty]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "El Email es Requerido")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        [BindProperty]
        [Display(Name = "Celular")]
        [Required(ErrorMessage = "Ingrese el numero de celular")]
        [Range(0, short.MaxValue, ErrorMessage = "El valor {0} debe ser numérico.")]
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