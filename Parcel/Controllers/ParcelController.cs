using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreatForm()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(int legnth, int width, int height, int weight)
    {
      Parcel myParcel = new Parcel(legnth, width, height, weight);
      return RedirectToAction("Index");
    }
  }
}