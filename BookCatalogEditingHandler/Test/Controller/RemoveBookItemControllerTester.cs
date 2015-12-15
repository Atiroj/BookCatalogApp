using BookCatalogController;
using BookCatalogEditingHandler.Context;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class RemoveBookItemControllerTester : GivenBookItemContextTester
  {
    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new RemoveBookItemController());
    }

    [Test]
    public void RemoveItem()
    {
      int previousCount = BookCatalogContext.BookItems.Count;

      var controller = new RemoveBookItemController();
      controller.Execute(0);

      Assert.AreEqual(previousCount -1, BookCatalogContext.BookItems.Count);
      Assert.AreEqual("Item has been removed", controller.ControlPresenter.PresentedData);
    }
  }
}