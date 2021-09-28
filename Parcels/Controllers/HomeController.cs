using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult HomePage()
    {
      return View();
    }
  }
}