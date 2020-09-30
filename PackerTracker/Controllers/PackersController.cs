using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class PackersController: Controller
  {
    [HttpGet("/packers")]
    public ActionResult Index()
    {
      List<Packer> allPackers = PackersController.GetAll();
      return View(allPackers);
    }

    [HttpGet("/packers/new")]
    public ActionResult New()
    {
      return view();
    }

    [HttpPost("/packers")]
    public ActionResult Create(string inputName, string inputCost)
    {
      Packer myPacker = new Packer(inputName, inputCost);
      return RedirectToAction("Index");
    }

    [HttpGet("/packers/{id}")]
    public ActionResult Show(int id)
    {
      Packer findList = Packer.Find(id);
      return View(findList);
    }
  }
}