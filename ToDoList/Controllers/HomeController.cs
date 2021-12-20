using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("/favorite_photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }
  }
}

// using Microsoft.AspNetCore.Mvc;
// using ToDoList.Models;

// namespace ToDoList.Controllers
// {
//   public class HomeController : Controller
//   {
//     [HttpGet("/")]
//     public ActionResult Index() // output: Item.cs
//     {
//       Item starterItem = new Item("Add first item to To Do List");
//       return View(starterItem);
//     }

//     [HttpGet("/items/new")]
//     public ActionResult CreateForm()
//     {
//       return View(); //renders CreateForm.cshtml automatically
//     }

//     [HttpPost("/items")] // invoked when form is submitted | matches specified action in CreateForm.cshtml
//     public ActionResult Create(string description) // description attribute comes from form field submission
//     {
//       Item myItem = new Item(description);
//       return View("Index", myItem); // first argument: view(html) that should be returned, second arg: specifies which iteration of which Model should be displayed. 
//     }
//   }
// }