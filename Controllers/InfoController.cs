using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace YourProjectNamespace.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}