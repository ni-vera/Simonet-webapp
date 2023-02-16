using Microsoft.AspNetCore.Mvc;
using webapp.Models;

namespace webapp.Controllers
{
    public class EntradaController : Controller
    {
        private readonly WebappDbContext _db;
        public EntradaController(WebappDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Entrada> objEntrada = _db.Entradas;
            return View(objEntrada);
        }

        public IActionResult IrA(int numpag = 1)
        {
            IList<Pagina> OnePage = new List<Pagina>
            {
                new Pagina(){Id = numpag, URL = "https://simonet.blob.core.windows.net/paginas/" + numpag + ".jpg"}
            };
            return View(OnePage);
        }
    }
}
