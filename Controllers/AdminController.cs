using Microsoft.AspNetCore.Mvc;
using System.Net;
using webapp.Models;

namespace webapp.Controllers
{
    public class AdminController : Controller
    {
        private readonly WebappDbContext _db;
        public AdminController(WebappDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VerPropuestas()
        {
            IEnumerable<Propuesta> objPropuesta = _db.Propuestas;
            return View(objPropuesta);
        }

        public IActionResult CrearEntrada(string entrada,int pagina )
        {
            Entrada nueva_entrada= new Entrada();
            nueva_entrada.entrada = entrada;
            nueva_entrada.pagina = pagina;
            _db.Entradas.Add(nueva_entrada);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PanelBorrar()
        {
            IEnumerable<Entrada> objEntrada = _db.Entradas;
            return View(objEntrada);
        }
        public IActionResult Borrar(string entrada)
        {
            Entrada entrada_borrar = (Entrada)_db.Entradas.Where(e => e.entrada == entrada).First();
            _db.Entradas.Remove(entrada_borrar);
            _db.SaveChanges();
            return RedirectToAction("PanelBorrar");
        }
    }
}
