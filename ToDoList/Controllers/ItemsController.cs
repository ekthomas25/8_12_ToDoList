using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    private readonly ToDoListContext _db; // declares a private and readonly field of type ToDoListContext.

    public ItemsController(ToDoListContext db) //  allows us to set the value of our new _db property to our ToDoListContext. This is achievable due to a dependency injection we set up in our AddDbContext method in the ConfigureServices method in our Startup.cs file.
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Item> model = _db.Items.ToList(); // Instead of using a verbose GetAll() method with raw SQL, we can instead access all our Items in List form by doing the following: _db.Items.ToList(). LINQ translates the dataset into a list we can use in the view
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Item item) // This route will take an item as an argument, add it to the Items DbSet, and then save the changes to our database object. Afterwards, it will redirect users to the Index view.
    {
      _db.Items.Add(item);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Item thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
      return View(thisItem);
    }
  }
}