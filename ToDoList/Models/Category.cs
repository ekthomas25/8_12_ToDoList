using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    public Category()
    {
      this.JoinEntities = new HashSet<Item>(); // HashSet = unordered collection of unique elements. We create a HashSet of Items in the constructor to help avoid exceptions when no records exist in the "many" side of the relationship. Also is more performant than a list. It can't have duplicates.
    }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<CategoryItem> JoinEntities {get; set; } 
    //Collection Navigation property - when you establish a many2many relationship between classes, we need to include this. It is a property on one class that includes a reference to a related class. Contains reference to many related Items. If don't have, can't access related Items in controllers and views.
    // public property that will return all Items that belong to a category. It is an instance of ICollection, a generic interface built into .NET framework (a collection of method signatures bundled together). Interfaces are often likened to "contracts" the developer "signs" because whenever a class extends an interface it must include every method outlined in the interface. ICollection is specifically a generic interface, which means it contains a bundle of different methods meant to work on a generic collection. We use it specifically because Entity requires it. 
    // By declaring Items as an ICollection<Item> data type, we're ensuring Entity will be able to use all the ICollection methods it requires on the Item objects in order to act as our ORM.
  }
}