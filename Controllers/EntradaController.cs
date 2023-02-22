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

        public IActionResult Index(string buscar)
        {
            var entradas = from entrada in _db.Entradas select entrada;
            if (!String.IsNullOrEmpty(buscar))
            {
                entradas = entradas.Where(s=>s.entrada!.Contains(buscar));
            }
            return View(entradas.ToList());
        }

        public IActionResult IrA(int numpag = 1)
        {
            IList<Pagina> OnePage = new List<Pagina>
            {
                new Pagina(){Id = numpag, URL = "https://simonet.blob.core.windows.net/paginas/" + numpag + ".jpg"}
            };
            return View(OnePage);
        }

        public IActionResult Contribuir()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contribuir(Propuesta obj)
        {
            if (ModelState.IsValid)
            {
                _db.Propuestas.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
