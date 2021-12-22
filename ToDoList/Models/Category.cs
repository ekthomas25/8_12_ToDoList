using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    public Category()
    {
      this.Items = new HashSet<Item>(); // HashSet = unordered collection of unique elements. We create a HashSet of Items in the constructor to help avoid exceptions when no records exist in the "many" side of the relationship. Also is more performant than a list. It can't have duplicates.
    }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Item> Items {get; set; } // public property that will return all Items that belong to a category.
  }
}