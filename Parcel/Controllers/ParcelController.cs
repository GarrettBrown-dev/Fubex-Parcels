using Microsoft.AspNetCore.Mvc;
using FubexParcel.Models;
using System.Collections.Generic;

namespace FubexParcel.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcel = Parcel.GetAll();
      return View(allParcel);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string name, string street, string city, string state, int length, int width, int height, int weight)
    {
      Parcel myParcel = new Parcel(name, street, city, state, length, width, height, weight);
      return RedirectToAction("Index");
    }
  }
}