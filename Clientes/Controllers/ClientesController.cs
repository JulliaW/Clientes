using Clientes.Data;
using Microsoft.AspNetCore.Mvc;

namespace Clientes.Controllers
{
    public class ClientesController : Controller
    {
        private readonly AppCont _appCont;

        public ClientesController(AppCont appCont)
        {
            _appCont = appCont;
        }

        public IActionResult Index()
        {
            var allTasks = _appCont.Clientes.ToList();
            return View(allTasks);
        }
    }
}
