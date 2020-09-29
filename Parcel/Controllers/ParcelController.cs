using Microsoft.AspNetCore.Mvc;
using FubexParcel.Models;
using System.Collections.Generic;

namespace FubexParcel.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcel")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcel/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Parcel myParcel = new Parcel(length, width, height, weight);
      return RedirectToAction("Index");
    }
  }
}