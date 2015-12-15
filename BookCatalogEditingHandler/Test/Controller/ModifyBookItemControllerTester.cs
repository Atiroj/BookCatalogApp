using BookCatalogController;
using BookCatalogEditingHandler.Context;
using NUnit.Framework;

namespace BookCatalogEditingHandler.Test
{
  [TestFixture]
  public class ModifyBookItemControllerTester : GivenBookItemContextTester
  {
    [Test]
    public void CanCreate()
    {
      Assert.IsNotNull(new ModifyBookItemController());
    }

    [Test]
    public void ModifyItem()
    {
      int previousCount = BookCatalogContext.BookItems.Count;
      var controller = new ModifyBookItemController();
      controller.Execute(0, "newName", "newPublisher");

      Assert.AreEqual(previousCount, BookCatalogContext.BookItems.Count);
      Assert.AreEqual("newName", BookCatalogContext.BookItems[0].Name);
      Assert.AreEqual("newPublisher", BookCatalogContext.BookItems[0].Publisher);
      Assert.AreEqual("Item has been modified", controller.ControlPresenter.PresentedData);
    }
  }
}