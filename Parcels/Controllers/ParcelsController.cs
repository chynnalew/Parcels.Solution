using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [Route("/cost")]
    public ActionResult Cost(string height, string width, string length)
    {
      int heightInt = int.Parse(height);
      int widthInt = int.Parse(width);
      int lengthInt = int.Parse(length);

      Parcel userParcel = new Parcel(heightInt, widthInt, lengthInt);
      return View(userParcel);
    }
  }
}