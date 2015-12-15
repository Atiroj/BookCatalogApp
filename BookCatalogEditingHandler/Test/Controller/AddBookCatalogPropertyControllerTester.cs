using System.CodeDom.Compiler;
using BookCatalogController;
using BookCatalogEditingHandler.Context;
using BookCatalogEditingHandler.ResponseModel;
using BookCatelogEditingHandler;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class AddBookCatalogPropertyControllerTester : GivenBookCatalogPropertyContextTester
  {
    private AddBookCatalogPropertyController _controller;

    [SetUp]
    public void SetUp()
    {
      _controller = new AddBookCatalogPropertyController();
    }

    [Test]
    public void Cancreate()
    {
      Assert.IsNotNull(_controller);
    }

    [Test]
    public void AddBookProperty()
    {
      int previousCount = BookCatalogContext.CatalogProperties.Count;
      _controller.Execute("newName", "newValue");
      Assert.AreEqual(previousCount + 1, BookCatalogContext.CatalogProperties.Count);
      Assert.AreEqual("Property has been added", _controller.ControlorPresenter.PresentedData);
    }
  }
}