using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DeploymentManualRazor.Pages.TemplatePDC
{
    public class PruebaModel : PageModel
    {



        [BindProperty]
        public string Nombre { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public IActionResult OnPost()
        {
            // Validar el formulario aqu� si es necesario...

            // Redireccionar a la p�gina PaginaDestino y pasar los datos como par�metros en la URL
            return RedirectToPage("/Excel", new { Nombre = Nombre, Email = Email });
        }
        //public IActionResult OnPost()
        //{

        //    return RedirectToPage("/Excel", new { Nombre = Nombre, Email = Email });
        //}
        //public IActionResult OnGetDemo()
        //{
        //    var nombre = Nombre;

        //    return new JsonResult(nombre);
        //}
        //public IActionResult OnPostDemo()
        //{


        //    return new JsonResult("Hola juanete");
        //}

    }
}
