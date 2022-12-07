using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());  //typeof returns data type of class, .GetType returns data type of a specific object
    }
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "Walk the dog";  //(Arrange)
      Item newItem = new Item(description); //create new item object, passing in the description (Arrange)

      string result = newItem.Description;  //set string to result of getting the Description property of newItem (Act)
      Assert.AreEqual(description, result); //make sure description retrieved from the Item object matches the description string (Assert)
    }
  }
}