using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext // Our ToDoListContext class inherits, or extends, from Entity Framework's DbContext. This ensures it includes all default built-in DbContext functionality.
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; } // contains a property of type DbSet named Items that represents the Items table in our ToDoList database and lets us interact with it. DbSet needs to know what C# object it’s going to represent, so we must include Item in the angle brackets (<>) after DbSet.
    public DbSet<CategoryItem> CagetoryItem { get; set; }
    public ToDoListContext(DbContextOptions options) : base(options) { } // This constructor inherits the behavior of its parent class constructor. ToDoListContext is an extension of the DbContext class, we're invoking some constructor behavior from that class. We pass a variable of DbContext Options called options to our constructor, instantiating ToDoListContext w/ the options we defined in Startup.cs - dependency injection.

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // enables lazy-loading.
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}