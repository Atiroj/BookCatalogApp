using BookCatalogController;
using BookCatalogEditingHandler.Context;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class AddBookItemControllerTester : GivenBookItemContextTester
  {
    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new AddBookItemController());
    }

    [Test]
    public void AddBookItem()
    {
      int previousCount = BookCatalogContext.BookItems.Count;
      var controller = new AddBookItemController();
      controller.Execute("newName", "newPublisher");
      Assert.AreEqual(previousCount + 1, BookCatalogContext.BookItems.Count);
      Assert.AreEqual("Item has been added", controller.ControlorPresenter.PresentedData);
    }
  }
}