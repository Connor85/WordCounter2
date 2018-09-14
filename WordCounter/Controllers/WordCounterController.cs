using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class RepeatCounterController : Controller
  {
    [HttpGet("/game")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/result")]
    public ActionResult Results()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["word"], Request.Form["phrase"]);
      return View("results", newRepeatCounter);
    }
  }
}
