using Microsoft.AspNetCore.Mvc;

namespace webdersi.Controllers
{
    public class HomeController:Controller
    {

        public IActionResult Index(){
            return View();
        }
        
    }
}