using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
