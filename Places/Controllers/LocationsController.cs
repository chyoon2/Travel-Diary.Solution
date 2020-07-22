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
    public ActionResult Create(string cityName, string url)
    {
      Location myLocation = new Location (cityName, url);
      return RedirectToAction("Index");
    }

    [HttpPost("/locations/delete")]
    public ActionResult Delete()
    {
      Location.ClearAll();
      return View();
    }

    [HttpGet("/locations/{id}")]
    public ActionResult Show(int id)
    {
      Location foundLocation = Location.Find(id);
      return View(foundLocation);
    }

  }
}