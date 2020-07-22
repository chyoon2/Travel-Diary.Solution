using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class LocationsController : Controller
  {
    [HttpGet("/locations")]
    public ActionResult Index()
    {
      List<Location> allPlaces = Location.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/locations/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/locations")]
    public ActionResult Create(string cityName)
    {
      Location myLocation = new Location (cityName);
      return RedirectToAction("Index");
    }
  }
}