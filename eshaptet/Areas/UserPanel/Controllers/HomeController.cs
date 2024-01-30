using Microsoft.AspNetCore.Mvc;

namespace eshaptet.Areas.UserPanel.Controllers;

[Area("UserPanel")]
public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}