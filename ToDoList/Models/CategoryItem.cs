namespace ToDoList.Models
{
  public class CategoryItem
  {
    public int CategoryItemId { get; set; } //Property
    public int ItemId { get; set; } //Property
    public int CategoryId { get; set; } //Property
    public virtual Item Item { get; set; } //Object
    public virtual Category Category { get; set; } //Object
  }
}