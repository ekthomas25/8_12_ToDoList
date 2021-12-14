using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace TodoList.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Item starterItem = new Item("Add first item to To Do List");
      return View(starterItem);
    }
  }
}