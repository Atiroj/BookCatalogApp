using System.CodeDom.Compiler;
using BookCatalogController;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.ResponseModel;
using BookCatelogEditingHandler;
using NUnit.Framework;

namespace BookCatalogController.Test
{
  [TestFixture]
  public class AddBookCatalogPropertyControllerTester 
  {
    private AddBookCatalogPropertyController _controller;

    [SetUp]
    public void SetUp()
    {
      _controller = new AddBookCatalogPropertyController();
    }

    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(_controller);
    }

    [Test]
    public void CheckResponesType()
    {
      _controller.Execute("newName, newValue");
      Assert.IsNotNull(_controller.ResponseModel);
      Assert.IsTrue(_controller.ResponseModel is AddBookCatalogProperyResponseModel);
    }    
  }
}