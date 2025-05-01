using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.Controllers
{
    public class AdminLayoutController1 : Controller
    {
        public IActionResult LayoutUI()
        {
            return View();
        }
    }
}
