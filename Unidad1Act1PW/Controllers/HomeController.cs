using Microsoft.AspNetCore.Mvc;
using Unidad1Act1PW.Models;

namespace Unidad1Act1PW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MiPerfilViewModel vm = new();
            vm.Nombre = "Jocelyn Berenice Zamora De la cerda";
            return View(vm);
        }
        public IActionResult MiPerfil() 
        {
            MiPerfilViewModel vm = new();
            vm.Nombre = "Jocelyn Berenice Zamora De la cerda";
            vm.Carrera = "Ing. Sistemas Computacionales";
            vm.Correo = "201g0293@rcarbonifera.tecnm.mx";
            vm.Semestre = 7;
            return View(vm);
        }
    }
}
