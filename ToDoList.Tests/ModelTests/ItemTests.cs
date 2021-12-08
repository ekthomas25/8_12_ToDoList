using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      // Arrange
      // 1. Create new string called description.
      string description = "Walk the dog.";
      // 2. Create new Item object, passing in the description.
      Item newItem = new Item(description);
      // Act
      // 3. Record the result of retrieving the description property of newItem.
      string result = newItem.Description;
      // Assert
      // 4. Confirm the description retrieved from the Item object matches the description string provided to the constructor.
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      // Act
      string updatedDescription = "Do the dishes";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Item> newList = new List<Item> { };
      // Act
      List<Item> result = Item.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}