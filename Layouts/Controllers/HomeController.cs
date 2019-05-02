using Microsoft.AspNetCore.Mvc;

namespace Layouts.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/lorem")]
      public ActionResult Lorem()
      {
        return View();
      }
    }
}
