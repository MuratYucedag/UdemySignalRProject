using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
