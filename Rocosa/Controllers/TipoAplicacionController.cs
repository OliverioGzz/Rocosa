using Microsoft.AspNetCore.Mvc;
using Rocosa.Datos;

namespace Rocosa.Controllers
{
    public class TipoAplicacionController : Controller
    {
        private ApplicationDbContext _db;
        public TipoAplicacionController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
