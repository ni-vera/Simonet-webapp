using Microsoft.AspNetCore.Mvc;
using webapp.Models;

namespace webapp.Controllers
{
    public class EjemploController : Controller
    {
        public IActionResult Index(int numpag = 1)
        {
            IList<Pagina> OnePage = new List<Pagina>
            {
                new Pagina(){Id = numpag, URL = "https://simonet.blob.core.windows.net/paginas/" + numpag + ".jpg"}
            };
            return View(OnePage);
        }  
    }
}
