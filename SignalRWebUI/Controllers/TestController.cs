using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Sepet()
        {
            return View();
        }
    }
}
