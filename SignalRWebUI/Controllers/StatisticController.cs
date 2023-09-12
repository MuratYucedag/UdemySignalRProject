using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
